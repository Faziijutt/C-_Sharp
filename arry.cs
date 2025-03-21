// using System;

// namespace Array
// {
//     class Program{
//     static void Main(){
//         // int[] a={3,5,6,56,78};
//         // foreach(int i in a)
//         // {
//         //     Console.Write(i+" ");
//         // }
        
//         // Console.WriteLine("Enter your 2 rows and 2 coulmn");
//         // int[,] a=new int[2,2];
//         // for(int i=0; i<2; ++i)
//         // {
//         //     for(int j=0; j<2; ++j){
//         //         a[i,j]=Convert.ToInt32(Console.ReadLine());
            
//         //     }
            
//         // }
//         // Console.WriteLine("result");
//         // for(int i=0; i<2; ++i)
//         // {
//         //     for(int j=0; j<2; ++j){
//         //         Console.Write(a[i,j]+"\t");
//         //     }
//         //     Console.WriteLine();
//         // }

//     }
// }

// }

// using System;
// namespace inheritence{
// class A{
//     protected int a=5,b=5,c;
//     public virtual void add()
//     {
//         c=a +b;
//         Console.WriteLine(c);
//     }
//     public virtual void sub()
//     {
//         c=a -b;
//         Console.WriteLine(c);
//     }
// }
// class B:A
// {
    
//     public override void add()
//     {
//         base.add();
//         c=a *b;
//         Console.WriteLine(c);
//     }
//     public override void sub()
//     {
//         base.sub();
//         c=a /b;
//         Console.WriteLine(c);
//     }
//     static void Main(){
//         B Faiz=new B();
//         Faiz.add();
//         // Faiz.add();
//         // Faiz.sub();
//         Faiz.sub();
                  
//   }
//   }


//   class faizan{
//     faizan(int i)
//     {
//         Console.WriteLine(i);
//     }
//     static void Main(){
//         faizan obj=new faizan(65);
//     }
//   }
// }