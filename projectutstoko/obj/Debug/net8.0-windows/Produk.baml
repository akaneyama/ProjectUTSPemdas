   M S B A M L   `   `   `  ����I  Eprojectutstoko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:projectutstokoprojectutstoko  5          projectutstoko.Produk   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:projectutstoko     5        N� Title$  Produk��5	      .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Daftar Produk��6   $��24(�65   $
��Bold"�6C   
���   �$��
10,10,0,20q�6h   $
��Left=�6|   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridProduk��5      $��1��6+      AutoGenerateColumns$ False��68   $��
10,0,10,10q�6T   $��Stretch=�5      $��Stretch=�6/   ���#ECECEC   AlternatingRowBackground �#F0F0F0   GridLinesVisibility$ 
Horizontal=�5   K      	RowHeight$ 40Q�6l      ColumnHeaderHeight$ 40Q�5      $��1q�6+   ���#CCCCCC	   CanUserAddRows$	 False��6U   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nama Produk��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.5* 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *nama_produk+6Z     5       $ Jumlah��6%   $ * 6W    65   �� *jumlah_produk+6W     5!      $ Harga��6%   $ * 6U    64   �� *harga_produk+6U     5"      $ 	Deskripsi��6%   $ 2* 6]    68   �� *deskripsi_produk+6]   5$      �� 5'   
   $��1��6   $��1��6"    �� Orientation$ Vertical=�62   $��	10,0,15,0q�6I   $	��Top=�6\   $	��250��6t   .+�5(      �� $��
ID Produk:��6   
���   �6)   �� 5)      -   5         ��Name$ txtIdProduk��5)      ${�False��6+   $��20��6=    �� 
IsReadOnly$
 True��6I   ���#ECECEC
���   �$��0,0,0,10q�6�   $��15(�6�   �� 5+      $��Nama Produk:��6   
���   �6+   �� 5,      -   5        $ txtNamaProduk��5,      ���#ECECEC$��15(�6B   $��20��6Q   
���   �$��0,0,0,10q�6p   �� 5.      $��Jumlah Produk:��6   
���   �6-   �� 5/      -   5        $ txtJumlahProduk��5/      ���#ECECEC$��20��6D   $��15(�6P   
���   �$��0,0,0,10q�6q   �� 51      $��Harga Produk:��6   
���   �6,   �� 52      -   5        $ txtHargaProduk��52      ���#ECECEC$��20��6D   $��15(�6P   
���   �$��0,0,0,10q�6q   �� 54      $��Deskripsi Produk:��6   
���   �60   �� 55      -   5        $ txtDeskripsiProduk��55      ���#ECECEC$��20��6G   $��15(�6S   
���   �$��0,0,0,10q�6t   �� 58      -   5        $��Tambah Produk��58      $	��150��6-   $��	10,10,0,0q�69   ���#1F78B4
�������$��10q�6t   $��0q�6�   59      �� 5:      -   5        $��Update Produk��5:      $	��150��6-   $��	10,10,0,0q�69   ���#1F78B4
�������$��10q�6t   $��0q�6�   5;      �� 5<      -	   5        $��Hapus Produk��5<      $	��150��6,   $��	10,10,0,0q�68   ���#1F78B4
�������$��10q�6s   $��0q�6�   5=      5>      5@      5A      