   M S B A M L   `   `   `  ����I  Eprojectutstoko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:projectutstokoprojectutstoko  5          projectutstoko.Pelanggan   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:projectutstoko     5        N� Title$  	Pelanggan��5	      .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Daftar Pelanggan��6   $��24(�68   $
��Bold"�6F   
���   �$��
10,10,0,20q�6k   $
��Left=�6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridPelanggan��5      $��1��6.      AutoGenerateColumns$ False��6;   $��
10,0,10,10q�6W   $��Stretch=�5      $��Stretch=�6/   ���#ECECEC   AlternatingRowBackground �#F0F0F0   GridLinesVisibility$ 
Horizontal=�5   K      	RowHeight$ 40Q�6l      ColumnHeaderHeight$ 40Q�5      $��1q�6+   ���#CCCCCC	   CanUserAddRows$	 False��6U   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nama Pelanggan��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.5* 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *nama_pelanggan+6`     5       $ Alamat��6%   $ * 6Z    65   �� *alamat_pelanggan+6Z     5!      $
 Telp��6%   $ * 6V    63   �� *telp_pelanggan+6V     5"      $ Email��6%   $ * 6X    64   �� *email_pelanggan+6X   5$      �� 5'   
   $��1��6   $��1��6"    �� Orientation$ Vertical=�62   $��	10,0,15,0q�6I   $	��Top=�6\   $	��250��6t   .+�5(      �� $��ID Pelanggan:��6   
���   �6,   �� 5)      -   5         ��Name$ txtIdPelanggan��5)      ${�False��6.   $��20��6@    �� 
IsReadOnly$
 True��6L   ���#ECECEC
���   �$��0,0,0,10q�6�   $��15(�6�   �� 5+      $��Nama Pelanggan:��6   
���   �6.   �� 5,      -   5        $ txtNamaPelanggan��5,      ���#ECECEC$��15(�6E   $��20��6T   
���   �$��0,0,0,10q�6s   �� 5.      $��Alamat:��6   
���   �6&   �� 5/      -   5        $ 	txtAlamat��5/      ���#ECECEC$��20��6>   $��15(�6J   
���   �$��0,0,0,10q�6k   �� 51      $��No Telp:��6   
���   �6'   �� 52      -   5        $ 	txtNoTelp��52      ���#ECECEC$��20��6?   $��15(�6K   
���   �$��0,0,0,10q�6l   �� 54      $��email:��6   
���   �6%   �� 55      -   5        $ txtEmail��55      ���#ECECEC$��20��6=   $��15(�6I   
���   �$��0,0,0,10q�6j   �� 58      -   5        $��Tambah Pelanggan��58      $	��150��60   $��	10,10,0,0q�6<   ���#1F78B4
�������$��10q�6w   $��0q�6�   59      �� 5:      -   5        $��Update Pelanggan��5:      $	��150��60   $��	10,10,0,0q�6<   ���#1F78B4
�������$��10q�6w   $��0q�6�   5;      �� 5<      -	   5        $��Hapus Pelanggan��5<      $	��150��6/   $��	10,10,0,0q�6;   ���#1F78B4
�������$��10q�6v   $��0q�6�   5=      5>      5@      5A      