   M S B A M L   `   `   `  ����I  Eprojectutstoko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:projectutstokoprojectutstoko  5      $    projectutstoko.TransaksiDetail   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:projectutstoko     5        N� Title$  TransaksiDetail��5	      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��View Transaksi��6   $��24(�6)   $
��Bold"�67   
���   �$��
10,10,0,20q�6\   $
��Left=�6p   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.   $
��Left=�6;   $��	0,10,0,20q�6V   .+�5      �� $��Nama Admin:��6   $��0,0,10,0q�6*   $��Center=�6<   �� 5      -   5         ��Name$ txtFilterAdmin��5      $	��150��6.   $��0,0,20,0q�6:   �� 5      $��Nama Produk:��6   $��0,0,10,0q�6+   $��Center=�6=   �� 5      -   5        $ txtFilterProduk��5      $	��150��6/   $��0,0,20,0q�6;   �� 5      $��Jumlah Transaksi:��6   $��0,0,10,0q�60   $��Center=�6B   �� 5      -   5        $ txtFilterJumlah��5      $	��100��6/   $��10��6;   $��0,0,20,0q�6E   �� 5       -   5        $��Terapkan Filter��5       ���#1F78B4
�������$��10q�6t   5!      &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ DataGridTransaksiView��5$      $��2��62      AutoGenerateColumns$ False��6?   $��
10,0,10,10q�6[   $��Stretch=�5%      $��Stretch=�6/   ���#ECECEC   AlternatingRowBackground �#F0F0F0   GridLinesVisibility$ 
Horizontal=�5&   6      	RowHeight$ 40Q�6W   	   ColumnHeaderHeight$	 40Q�5'      $��1q�6+   ���#CCCCCC
   CanUserAddRows$
 False��6U      Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Nama Admin��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
nama_admin+6X     5*      $ Nama Produk��6%   $ 2* 6Z    6:   �� *nama_produk+6Z     5+      $ ID Transaksi��6%   $ 1* 6\    6;   �� *id_transaksi+6\     5,      $ Jumlah Pembelian��6%   $
 1.5* 6a    6?   �� *jumlah_produk+6a     5-      $ Harga Produk��6%   $
 1.5* 6\    6;   �� *harga_produk+6\     5.      $ Subtotal��6%   $
 1.5* 6T    67   �� *
subtotal+6T   50      51      52      