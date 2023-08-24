import { MultiLanguageText } from "@bimser/form-controls/entities/common";

export default class Form1 extends Form.Designer {

        zamanHesaplama(){
        const dateStart=new Date(this.startDate.value);
        const dateFinished=new Date(this.endDate.value);
        const zamanFark=Math.abs(dateFinished.getTime() - dateStart.getTime());
        const aradakiFark=Math.ceil(zamanFark / (1000 * 60 * 60 * 24));
        this.kalanSuresi.text=aradakiFark.toString();

        if(dateFinished>dateStart){
                this.kalanSuresi.customClassName= "kalanSure1"
        }
        else{
                this.kalanSuresi.customClassName= "kalanSure0"
        }
        
        }
        
	async startDate_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<Date>) {
        this.zamanHesaplama();
	}

	async endDate_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<Date>) {
        this.zamanHesaplama();
	}

	async Form1_OnBeforeSave(args: Controls.EventArgs.IBeforeSaveEventArgs) {
                if(this.startDate.value>this.endDate.value){
                        alert("Başlangıç tarihi Bitiş tarihinden sonra olamaz");
                        args.cancel=true;
                }
	}

	async asamaTablo_OnRowInserting(args: Controls.EventArgs.IRowInsertingEventArgs) {
        args.row['yuzdeAsama'] = this.gorevYuzde.value * 5;
	}

	async Form1_OnLoad(args: Controls.EventArgs.ILoadEventArgs) {
        this.zamanHesaplama();
	}
}
