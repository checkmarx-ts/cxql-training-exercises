#include <stdlib.h>

/*
 * Run, for example, the Buffer_Improper_Index_Access query.
 */
void fun_a(int c) {
  int a1[200];
  int a2[100];
  int x = 12;
  if (c) x += 100;
  a1[x] = 1;
  a2[x] = 1;
}

/*
 * Run, for example, the Improper_Null_Termination query.
 */
void fun_b(int size, char *s) {
  char *buf;

  buf = (char *) malloc(size);

  memcpy(buf, s, size);
}
