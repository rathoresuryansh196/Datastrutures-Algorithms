#include<iostream>
using namespace std;
#include<conio.h>
template <class T>
class bsearc
{
  public:
    T x,a[100];
    int low,high,mid;          //initial, final and mid indices markers
    int n;
    void input(void);
    void search(void);
};

template<class T>
void bsearc<T>::input(void)
{     
     cout<<"enter the number of elements you want to enter\n";
     cin>>n;
     cout<<"enter the elements\n";
     for(int i=0;i<n;i++)
     {
        cin>>a[i];
     }
     
     cout<<"enter the element you want to search\n";
     cin>>x;
    }
 
 template<class T>
 void bsearc<T>::search(void)
 { 
    low=1;
    high=n;
    while(low<=high)
    {
      mid=(low+high)/2;
      if(x==a[mid])                       //search at mid
      {
        cout<<"element found";
        break;
      }
      else if(x<a[mid])                   //if value less than mid: search in left half of current range. 
        high=mid-1;
      else 
        low=mid+1;                        //if value greater than mid: search in right half of current range.
    }
     if(low>high)                         //termination condition of binary search.
       cout<<"element not found\n";
  }
         
  int main()
  {
    // we solve binary search by dividing our problem to sub problem at each step.
    // if T(n) represents complexity at each step,
    // then T(n)=T(n/2)+O(1)
    // calculating complexity using Master's Theorem
    // T(n)=O(log(n))
    bsearc <int> b;
    b.input();
    b.search();
    _getch();
    return 0;
  }        
         
        
                                                
