implicit type conversion

bytes take 1 byte of memory
int takes 4 bytes of memory

byte b = 1;
int i = b;

int i = 1;
float a = i;


int i = 1;
byte b = i;
-- data loss won't happen but won't compile



Explicit type conversion (casting)

int i = 1;
byte b = (byte)i;
-- data won't occur and will compile

float f = 1.0f
int i = (int)f;



Non-compatible types

string s = "1";
int i = (int)s
-- won't compile

so string -> number needs a convert class or parse method

.net gives us the convert class
string s = "1";
int i = Convert.ToInt32(s);
or
int j = int.Parse(s);

