   M S B A M L   `   `   `  ����N  JValoStatsTrackerApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ValoStatsTrackerApp.PagesValoStatsTrackerApp.Pages  5   	   4    .ValoStatsTrackerApp.Pages.InsertPurchaseWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ValoStatsTrackerApp.Pages     5   	     � Title$  InsertPurchaseWindow��5   	   $	��450��6&   $	��250��63   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��Center=�6   $��0��6/   $��1��6<   $��PlayerID/BattleID:��6L   �� 5   
   -   5         ��Name$ playerID��5   D   $��10,15,10,15q�6   $��0��6'   $��2��64   6D   �� 5   
   $��Center=�6   $��1��6/   $��1��6<   $��PurchaseID:��6L   �� 5   
   -   5        $ 
purchaseID��5   D   $��10,15,10,15q�6   $��1��6'   $��2��64   6D   �� 5!   
   $��Center=�6   $��2��6/   $��1��6<   $��Purchase Item:��6L   �� 5"   
   -   5        $ purchaseItem��5"   D   $��10,15,10,15q�6   $��2��6'   $��2��64   6D   �� 5$   
   $��Center=�6   $��3��6/   $��1��6<   $��Cost:��6L   �� 5%   
   -   5        $ purchaseCost��5%   D   $��10,15,10,15q�6   $��3��6'   $��2��64   6D   �� 5'   
   $��Center=�6   $��4��6/   $��1��6<   $��Amount Paid:��6L   �� 5(   
   -   5        $ 
paidAmount��5(   D   $��10,15,10,15q�6   $��4��6'   $��2��64   6D   �� 5*   
   $��Center=�6   $��5��6/   $��1��6<   $��Purchase Date:��6L   �� 5+   
   -   5        $ purchaseDate��5+   D   $��10,15,10,15q�6   $��5��6'   $��2��64   $��
YYYY-MM-DD��6Z   �� 5-   
   -   5        $��1��5-      $��6��6!   $��10,15,10,15q�6.   $��2��6C   $��Insert��6W   6h   5.      5/      