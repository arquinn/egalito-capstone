# CS_ARCH_ARM, CS_MODE_THUMB, None
0xc0,0xee,0x90,0x1b = vdup.8 d16, r1
0x8f,0xee,0x30,0x2b = vdup.16 d15, r2
0x8e,0xee,0x10,0x3b = vdup.32 d14, r3
0xe2,0xee,0x90,0x4b = vdup.8 q9, r4
0xa0,0xee,0xb0,0x5b = vdup.16 q8, r5
0xae,0xee,0x10,0x6b = vdup.32 q7, r6
0xf1,0xff,0x0b,0x0c = vdup.8 d16, d11[0]
0xf2,0xff,0x0c,0x1c = vdup.16 d17, d12[0]
0xf4,0xff,0x0d,0x2c = vdup.32 d18, d13[0]
0xb1,0xff,0x4a,0x6c = vdup.8 q3, d10[0]
0xf2,0xff,0x49,0x2c = vdup.16 q9, d9[0]
0xf4,0xff,0x48,0x0c = vdup.32 q8, d8[0]
0xf3,0xff,0x0b,0x0c = vdup.8 d16, d11[1]
0xf6,0xff,0x0c,0x1c = vdup.16 d17, d12[1]
0xfc,0xff,0x0d,0x2c = vdup.32 d18, d13[1]
0xb3,0xff,0x4a,0x6c = vdup.8 q3, d10[1]
0xf6,0xff,0x49,0x2c = vdup.16 q9, d9[1]
0xfc,0xff,0x48,0x0c = vdup.32 q8, d8[1]