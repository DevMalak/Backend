namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            #region  Data Structures Task (Stack, Queue, Dictionary)


            // Define our data structures


            Dictionary<int, string> studentData = new Dictionary<int, string>();
            Queue<int> serviceQueue = new Queue<int>();
            Stack<int> undoStack = new Stack<int>();

            bool run = true;

            while (run)
            {
                // The Menu exactly which we want
                Console.WriteLine("\n--- Student Service Center Menu ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Show All Students");
                Console.WriteLine("5. Join Service Queue");
                Console.WriteLine("6. Serve Next Student");
                Console.WriteLine("7. Undo Last Service");
                Console.WriteLine("8. Show Queue");
                Console.WriteLine("9. Exit");
                Console.Write("Choose an option: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: // Add new student
                            try
                            {
                                Console.Write("ID: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                if (!studentData.ContainsKey(id))
                                {
                                    Console.Write("Name: ");
                                    studentData.Add(id, Console.ReadLine());
                                    Console.WriteLine("Added!");
                                }
                                else { Console.WriteLine("ID exists!"); }
                            }
                            catch (Exception ex) { Console.WriteLine("Error in Add"); }
                            break;

                        case 2: // update name
                            try
                            {
                                Console.Write("ID to update: ");
                                int upId = Convert.ToInt32(Console.ReadLine());
                                if (studentData.ContainsKey(upId))
                                {
                                    Console.Write("New Name: ");
                                    studentData[upId] = Console.ReadLine();
                                    Console.WriteLine("Updated!");
                                }
                            }
                            catch (Exception ex) { Console.WriteLine("Error in Update"); }
                            break;

                        case 3: // Remove student
                            try
                            {
                                Console.Write("ID to remove: ");
                                int remId = Convert.ToInt32(Console.ReadLine());
                                studentData.Remove(remId);
                                Console.WriteLine("Removed!");
                            }
                            catch (Exception ex) { Console.WriteLine("Error in Remove"); }
                            break;

                        case 4: // Show all (Dictionary)
                            foreach (var item in studentData)
                                Console.WriteLine("ID: " + item.Key + ", Name: " + item.Value);
                            break;

                        case 5: // join Queue
                            try
                            {
                                Console.Write("Enter ID to join: ");
                                int qId = Convert.ToInt32(Console.ReadLine());
                                if (studentData.ContainsKey(qId))
                                {
                                    serviceQueue.Enqueue(qId);
                                    Console.WriteLine("Joined queue.");
                                }
                            }
                            catch (Exception ex) 
                        { Console.WriteLine("Error in Queue"); }
                            break;

                        case 6: // Serve student (FIFO)
                            if (serviceQueue.Count > 0)
                            {
                                int served = serviceQueue.Dequeue();
                                undoStack.Push(served);
                                Console.WriteLine("Serving: " + studentData[served]);
                            }
                            else { Console.WriteLine("Queue is empty."); }
                            break;

                        case 7: //undo (LIFO)
                            if (undoStack.Count > 0)
                            {
                                int last = undoStack.Pop();
                                serviceQueue.Enqueue(last); // Back to queue
                                Console.WriteLine("Undo: " + studentData[last] + " returned");
                            }
                            else { Console.WriteLine("Nothing to undo."); }
                            break;

                        case 8: // Show Queue
                            foreach (int idInQ in serviceQueue)
                            Console.WriteLine("Waiting: " + studentData[idInQ]);
                            Console.WriteLine("Total students in queue: " + serviceQueue.Count);
                            break;
                            

                        case 9: // Exit
                            run = false;
                            Console.WriteLine("Thank you!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex) { Console.WriteLine("Please enter a number!"); }
            } 
            #endregion
        }
    }




    }



    
    

