namespace Assignment04_ADV04
{
    internal class Program
    {
        #region Q1

        static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }


        #endregion

        #region Q2

        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                        return false; 

                    char top = stack.Pop();

                    if ((ch == ')' && top != '(') ||
                        (ch == ']' && top != '[') ||
                        (ch == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }

            #endregion
        static void Main(string[] args)
        {
            #region Q1

            //Queue<int> numbers = new Queue<int>();
            //numbers.Enqueue(10);
            //numbers.Enqueue(20);
            //numbers.Enqueue(30);
            //numbers.Enqueue(40);

            //Console.WriteLine("Original Queue: " + string.Join(", ", numbers));

            //ReverseQueue(numbers);

            //Console.WriteLine("Reversed Queue: " + string.Join(", ", numbers)); 

            #endregion

            #region Q2

            //string input = "[()]{ }";

            //if (IsBalanced(input))
            //    Console.WriteLine("Balanced");
            //else
            //    Console.WriteLine("Not Balanced");


            #endregion
        }
    }
}
