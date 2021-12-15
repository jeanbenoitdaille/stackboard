    using System;
     
    namespace Coding.Exercise
    {
        public class Stack
        {
            private int[] stack;
            private int position;
        
            public Stack(int size)
            {
                position = 0;
                stack = new int[size];
            }
     
            public void Push(int value)
            {
              if(position >= stack.Length){
                var temp = new int[position+1];
                for(var i = 0; i < stack.Length; i++){
                  temp[i] = stack[i];
                }
              stack = temp;
               stack[position] = value;
                position++;
              } else {
               stack[position] = value;
               position++;
              }
            }
     
            public int Pop()
            {
              if (position > 0)
                {
                    position -= 1;
                    return stack[position];
                }
                return 0;
            }
        }
    }