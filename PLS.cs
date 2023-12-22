private void Bt_EditPLC_Click(object sender, RoutedEventArgs e) { 
    if (SelectedSiemensPLC != null) { 
        SiemensEditor SiemensEditForm = new SiemensEditor(SelectedSiemensPLC.MySetUplnfo); 
        SiemensEditForm.ShowDialog(); 
        if (SiemensEditForm.DialogResult == true) {
            if(sQLite.UpdatePLClnDB(SiemensEditForm.Mylnfo)) { 
                SelectedSiemensPLC.MySetUplnfo = SiemensEditForm.Mylnfo;
                ItemsConnection(SelectedSiemensPLC); 
                } 
            else { MessageBox.Show("PLC updating is failed."); } 
        } else { MessageBox.Show("PLC updating is canceled.");} 
        SiemensEditForm.Close(); 
    } else { MessageBox.Show("Not selected PLC") } 
}