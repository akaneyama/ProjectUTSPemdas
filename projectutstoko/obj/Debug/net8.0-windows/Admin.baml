   M S B A M L   `   `   `  ����I  Eprojectutstoko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:projectutstokoprojectutstoko  5          projectutstoko.Admin   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:projectutstoko     5        N� Title$  Admin��5	      .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��Daftar Admin��6   $��24(�64   $
��Bold"�6B   
���   �$��
10,10,0,20q�6g   $
��Left=�6{   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridAdmin��5      $��1��6*      AutoGenerateColumns$ False��67   $��
10,0,10,10q�6S   $��Stretch=�5      $��Stretch=�6/   ���#ECECEC   AlternatingRowBackground �#F0F0F0   GridLinesVisibility$ 
Horizontal=�5   K      	RowHeight$ 40Q�6l      ColumnHeaderHeight$ 40Q�5      $��1q�6+   ���#CCCCCC	   CanUserAddRows$	 False��6U   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Nama Admin��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.5* 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
nama_admin+6X     5      $ 
Telp Admin��6%   $ * 6X    69   �� *
telp_admin+6X     5       $ Username��6%   $ * 6T    67   �� *
username+6T   5"      �� 5%   
   $��1��6   $��1��6"    �� Orientation$ Vertical=�62   $��	10,0,15,0q�6I   $	��Top=�6\   $	��250��6t   .+�5&      �� $��	ID Admin:��6   
���   �6(   �� 5'      -   5         ��Name$ 
txtIdAdmin��5'      ${�False��6*   $��20��6<    �� 
IsReadOnly$
 True��6H   ���#ECECEC
���   �$��0,0,0,10q�6�   $��15(�6�   �� 5)      $��Nama Admin:��6   
���   �6*   �� 5*      -   5        $ txtNamaAdmin��5*      ���#ECECEC$��15(�6A   $��20��6P   
���   �$��0,0,0,10q�6o   �� 5,      $��No Telp:��6   
���   �6'   �� 5-      -   5        $ txtTelpAdmin��5-      ���#ECECEC$��20��6A   $��15(�6M   
���   �$��0,0,0,10q�6n   �� 5/      $��	Username:��6   
���   �6(   �� 50      -   5        $ txtUsername��50      ���#ECECEC$��20��6A   $��15(�6M   
���   �$��0,0,0,10q�6n   �� 52      $��	Password:��6   
���   �6(   G� 53      -   5         G�Name$ txtPassword��53      ���#ECECEC$��20��6D   $��15(�6P   
���   �$��0,0,0,10q�6q   �� 55      -   5        $��Tambah Admin��55      $	��150��6,   $��	10,10,0,0q�68   ���#1F78B4
�������$��10q�6s   $��0q�6�   56      �� 57      -   5        $��Update Admin��57      $	��150��6,   $��	10,10,0,0q�68   ���#1F78B4
�������$��10q�6s   $��0q�6�   58      �� 59      -	   5        $��Hapus Admin��59      $	��150��6+   $��	10,10,0,0q�67   ���#1F78B4
�������$��10q�6r   $��0q�6   5:      5;      5=      5>      