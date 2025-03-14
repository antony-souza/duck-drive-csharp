﻿using DuckDisk.services;
using Figgle;

namespace DuckDisk.utils;

public class MainMenu
{

    public static void ShowMainMenu()
    {
        DriveService driveService = new DriveService();
        IsoService isoService = new IsoService();
        BootableDriveService bootableDriveService = new BootableDriveService();
        while (true)
        {
            Console.Clear();
            DuckDriveTitle.DisplayTitle();
            Console.WriteLine("----- Menu do Duck Drive -----");
            Console.WriteLine();
            Console.WriteLine("1. Menu de Drives");
            Console.WriteLine("2. Menu de ISO's");
            Console.WriteLine("3. Menu de Criação do Drive Bootável");
            Console.WriteLine("4. Sair");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    driveService.MenuDrives();
                    break;

                case "2":
                    isoService.IsoMenu();
                    break;

                case "3":
                    bootableDriveService.MenuBootableDrive();
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("\nOpção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao Menu Principal...");
            Console.ReadKey();
        }
    }
}