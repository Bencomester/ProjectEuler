#include <iostream>

using namespace std;

int coins[] = { 1, 2, 5, 10, 20, 50, 100, 200 };

int count(int sum = 0, int index = 7) {
    if (sum == 200) return 1;
    if (sum > 200) return 0;
    if (index == 0) return 1;
return count(sum + coins[index], index) + count(sum, index - 1);
}

int main()
{
    cout << count() << endl;
}
