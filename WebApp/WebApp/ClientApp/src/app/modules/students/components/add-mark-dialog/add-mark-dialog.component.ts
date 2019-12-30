import { Component, OnInit, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { FormGroup, FormControl, Validators } from '@angular/forms';


export class AddMarkDialogData{
  courseName: string;
}

@Component({
  selector: 'app-add-mark-dialog',
  templateUrl: './add-mark-dialog.component.html',
  styleUrls: ['./add-mark-dialog.component.css']
})
export class AddMarkDialogComponent implements OnInit {

  

  markFormGroup : FormGroup ;

  constructor(
    public dialogRef: MatDialogRef<AddMarkDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: AddMarkDialogData) 
    {}


  ngOnInit() {

      this.markFormGroup = new FormGroup({
        mark: new FormControl(null, [Validators.required, Validators.min(1), Validators.max(10)])
      });
  }

  public onSave(): void{

    if(this.markFormGroup.get("mark").valid){
      this.dialogRef.close(this.markFormGroup.get("mark").value);
    }
    else{
      this.markFormGroup.get("mark").markAsTouched();
    }


    // var mark = this.markFormGroup.get("mark").value;

    // if(mark !== undefined && mark !== null){
    // }
  }


  public showError(): boolean{
    return ! this.markFormGroup.get("mark").valid;
  }

  public isSaveDisabled(): boolean{
    if(this.markFormGroup)
    {
        var mark = this.markFormGroup.get("mark").value;

        return mark === undefined || mark === null;
    }
    return true;
  }
  

  public onCancel(): void {
    this.dialogRef.close();
  }

}


