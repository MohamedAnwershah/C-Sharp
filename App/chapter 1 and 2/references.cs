//ref locals
int[] numbers = { 0, 1, 2, 3 };
ref int numRef = ref numbers[2];
numRef *= 10;

//ref returns
static string x = "Old";
static ref string GetX() => ref x;

ref string xRef = ref GetX();
xRef = "New";