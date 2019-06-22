byte number = 255;

255 is the largest value in a byte

so when:

byte = byte + 1;

byte = 0 since we overflowed on the data struct.


to stop overflowing, use the CHECKED keyword:

checked {
    byte number = 255;

    number = number + 1;
}
with checked, overflow won't happen at runtime and it will instead throw an exception


