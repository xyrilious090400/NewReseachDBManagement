   M S B A M L   `   `   `  ����e  aXyrille.ResearchDatabaseManagement.Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Jclr-namespace:Xyrille.ResearchDatabaseManagement.Windows.ResearchesWindows<Xyrille.ResearchDatabaseManagement.Windows.ResearchesWindows  5   	   G    AXyrille.ResearchDatabaseManagement.Windows.ResearchesWindows.List   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   \localJclr-namespace:Xyrille.ResearchDatabaseManagement.Windows.ResearchesWindows     5   	     � Title$
  List��5   	   $	��450��6   $	��800��6#   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgEmployees��5
      $
��Left=�6(   $	��214��6C   $��
46,102,0,0q�6P   $	��Top=�6d   $	��704��6|      AutoGenerateColumns .     CanUserAddRows .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Author��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5   0   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *Author+60     5      $ Title��6%   $ * 5   /    6   �� *Title+6/     5      $ Abstract��6%   $ * 5   2    6   �� *
Abstract+62     5      $ Leadline��6%   $ * 5   2    6   �� *
Leadline+62     5      $
 Year��6%   $ * 5   .    6   �� *Year+6.   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      �� 	 ��Name$	 	btnUpdate��6%   -   5        $��Update��5   P   5      5        5       5      �� 5      .R�5       �� $	 	btnDelete��6%   -   5        $��Delete��5    P   5!      5#        5$       5%      �� 5&      .R�5'      �� $	 btnDeactivate��6%   -   5        $��
Deactivate��5'   X   5(      5*      5-      �� 5.   
   -   5        
 ��Name$
 cboSortOrder��5.      $
��Left=�6)   $��
629,34,0,0q�6D   $	��Top=�6X   $	��120��6p   6|   �� 5/   
   -   5         ��Name$ lblSortOrder��5/      $��
Sort Order��6&   $
��Left=�6;   $��29��6V   $��
537,34,0,0q�6b   $	��Top=�6v   $��87��6�    J� RenderTransformOrigin$ 0.783,0.576&�6�   �� 50   
   -   5        $
 	cboSortBy��50      $
��Left=�6&   $��
407,34,0,0q�6A   $	��Top=�6U   $	��120��6m   6y   �� 51   
   -   5        $ 	lblSortBy��51      $��Sort By��6#   $
��Left=�65   $��29��6P   $��
315,34,0,0q�6\   $	��Top=�6p   $��87��6�   $ 0.783,0.576&�6�   �� 52   
   -	   5        $	 btnFirst��52      $��First��6#   $
��Left=�63   $	��Top=�6N   $��75��6f   $��18��6q   $��
46,340,0,0q�6}   6�   �� 53   
   -
   5        $	 btnLast��53      $
��Last��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��286,340,0,0q�6{   6�   �� 54   
   -   5        $	 btnNext��54      $
��Next��6"   $
��Left=�61   $	��Top=�6L   $��75��6d   $��18��6o   $��206,340,0,0q�6{   $ 0.615,2.311&�6�   6�   �� 55   
   -   5        $	 btnPrevious��55      $��Previous��6&   $
��Left=�69   $	��Top=�6T   $��75��6l   $��18��6w   $��126,340,0,0q�6�   6�   �� 56   
   -   5         ��Name$ txtPageSize��56      $��5��6'   $
��Left=�60   $��23��6K    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $��75��6�   $��126,363,0,0q�6�   6�   �� 57   
   -   5        $ lblPageSize��57      $��	Page Size��6%   $
��Left=�69   $	��Top=�6T   $��
46,363,0,0q�6l   �� 58   
   -   5        $ 
lblFilters��58      $��Filters��6$   $
��Left=�66   $��29��6Q   $��	46,68,0,0q�6]   $	��Top=�6p   $��87��6�   $ 0.783,0.576&�6�   �� 59   
   -   5        $ 
txtKeyword��59      $
��Left=�6&   $��23��6A   $��
100,67,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��648��6�   6�   �� 5:   
   -   5        $	 btnAdd��5:      $��Add New��6!   $
��Left=�63   $	��Top=�6N   $��75��6f   $��18��6q   $��673,340,0,0q�6}   6�   5<      5=      