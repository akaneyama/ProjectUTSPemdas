   M S B A M L   `   `   `  ����I  Eprojectutstoko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:projectutstokoprojectutstoko  5          projectutstoko.Transaksi   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:projectutstoko     5        N� Title$  	Transaksi��5
       � 	Resources 5       �� 
TargetType �� Property �� Value&   System.Windows.Controls.DataGrid��%2  '��       '  �    '�� �    �� 5   
   " ��6   .�5      ��  � ��$	 120��6&   �� 5       � ��$ 40��6'   �� 5       � ��$ 10q�6'   �� 5       � �� �#4CAF506+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��
 ���� 6,   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ 0q�60   �� 5       � ��$
 10,5q�6(   5      �� 5   
   "  6   .�5      ��  �@ RowBackground �#F1F1F16.   �� 5        �@ AlternatingRowBackground �#E7E7E769   �� 5       �@ GridLinesVisibility$
 None=�64   �� 5       � ��$ 10q�6'   5       �� 5#   
   " ��6   .�5$      ��  � ��$
 Bold"�6+   �� 5%       � ��$ 10,5,0,5q�6'   5&      5'      .��5)      � ���#F9F9F9.+�5*   
   �� ���#D0D0D0$��1q�6'    �� CornerRadius$ 8��6;    �� Padding$ 20q�6L   
�������$��
0,0,0,-343q�6l   ._�5,      �� $��0q�6   .+�5-      �� $��Cari Produk:��6   $
��Bold"�60   $��Center=�6C   �� 5.      -   5         ��Name$ txtCariProduk��5.      $	��200��61   6=   �� 5/      $��Cari Pelanggan:��6   $
��Bold"�63   $��Center=�6F   �� 50      -   5        $ txtCariPelanggan��50      $	��200��64   6@   �� 51       �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�52        -   5        	  Name$	 dataGridProduk��52      
   AutoGenerateColumns$
 False��67   $	��200��6S   $��0,10,0,0q�6`   $	��700��6r      Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ 	ID Produk��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
IdProduk+6a     55      $ Nama Produk��61   $ * 6e    6F   �� *
NamaProduk+6e     56      $ Harga Produk��61   $ * 6g    6G   �� *HargaProduk+6g     57      $
 Stok��61   $ * 6`    6?   �� *JumlahProduk+6`   59        5;      -   5        $	 dataGridPelanggan��5;      $	��700��6:   $
 False��6F   $	��200��6b   $��	10,10,0,0q�6o    5<        5=      $ ID Pelanggan��61   $ 1* 6g    6G   �� *IdPelanggan+6g     5>      $ Nama Pelanggan��61   $ 4* 6k    6I   �� *NamaPelanggan+6k   5A      5C      �� 5H      -   5         ��Name$ 
btnRefresh��5H      $��Refresh��6-   $	��100��6?   $��Right=�6K   6g   �� 5J      $��Form Transaksi��6   $��20(�62   $
��Bold"�6@   ���#333$��0,0,0,20q�6d   $��Center=�6v   � 5M      $��0,0,0,20q�6    � ColumnDefinitions 5N      �� 5O      $��* �6+   �� 5P      $��* �6+   .+�5T      �� $��0��6!   $��0,0,10,0q�61   .+�5U      �� $��
Pelanggan:��6    �� 5V      -   5         ��Name$ cmbPelanggan��5V   #    �� DisplayMemberPath$ NamaPelanggan��69   6[   5W      �� 5Z      $��1��6!   .+�5[      �� $��Produk:��6    �� 5\      -   5        $ 	cmbProduk��5\   #   $ 
NamaProduk��66   6U   5]      5^      � 5a      $��0,0,0,20q�6    5b      �� 5c      $��* �6+   �� 5d      $��* �6+   .+�5h      �� $��0��6!   $��0,0,10,0q�61   .+�5i      �� $��Jumlah:��6    �� 5j      -   5        $ 	txtJumlah��5j   "   5k      �� 5n      $��1��6!   .+�5o      �� $��Harga Satuan:��6    �� 5p      -	   5        $ txtHargaSatuan��5p   "    �� 
IsReadOnly$
 True��6:   5q      5r      �� 5u      $ 
Horizontal=�6   $��Center=�66   $��0,0,0,20q�6S   .+�5v      �� -
   5        $ 	BtnTambah��5v      $��Tambah��60   6A   �� 5w      -   5        $��Simpan��5w      ���#2196F36F   �� 5x      -   5        $��Hapus Produk��5x      $
��Left=�64   $��10q�6O   6[   5z        5}      -   5        $	 dataGridTransaksi��5}      $
 False��66   $	��200��6R    5~        5      $ Produk��6-    6=   �� *Produk+  5�      $ Jumlah��6-    6=   �� *Jumlah+  5�      $ Harga Satuan��6-    6C   �� *HargaSatuan+  5�      $ Subtotal��6-    6?   �� *
Subtotal+5�      �� 5�      $ 
Horizontal=�6   .+�5�      �� $
��Bold"�6    $��Total: ��62   $��20(�6A   $
��left=�6O   $��10 0 0 0q�6j   �� 5�      -   5         ��Name$ txtTotalHarga��5�       $
��Bold"�67   $��0��6I   $��20(�6R   $
��left=�6`   $��0 0 0 0q�6{   5�      5�      5�      5�      5�      