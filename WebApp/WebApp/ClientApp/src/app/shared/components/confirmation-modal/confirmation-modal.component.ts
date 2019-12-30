import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';


export class ConfirmationModalData{
  name: string;
}

@Component({
  selector: 'app-confirmation-modal',
  templateUrl: './confirmation-modal.component.html',
  styleUrls: ['./confirmation-modal.component.css']
})
export class ConfirmationModalComponent implements OnInit {

  constructor(
    public dialogRef: MatDialogRef<ConfirmationModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: ConfirmationModalData) 
    {}

    ngOnInit() {
    }

    public onYes(): void{
      this.dialogRef.close(true);
    }

    public onNo(): void{
      this.dialogRef.close(false);
    }




}
