﻿int somme(int x, int y) {
    return x + y;
}

bool supeq_ou_pas(int a, int b) {
    return a>=b;
}

int opposer_de_z(int z) {
    return -z;
}

int x = 2;
int y = 3;
int a = 6;
int b = 3;
int z = -7;
int resultat = somme(x,y);
bool resultat_supeg_ou_pas = supeq_ou_pas(a,b);
int opposer = opposer_de_z(z);

Console.WriteLine($"La somme de {x} et {y} est {resultat}");
Console.WriteLine(resultat_supeg_ou_pas ? $"{a} est superieur ou egal à {b}" : $"{a} n'est superieur ou egal à {b}");
Console.WriteLine($"L'opposer de {z} est {opposer}");

