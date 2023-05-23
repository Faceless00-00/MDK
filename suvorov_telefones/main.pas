unit Main;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, Forms, Controls, Graphics, Dialogs, ExtCtrls, Buttons,
  Grids, edit;
type
  Contacts = record
    Name: string[100];
    Telephon: string[20];
    Note: string[20];
  end;

type

  { TfMain }

  TfMain = class(TForm)
    Panel1: TPanel;
    bAdd: TSpeedButton;
    bEdit: TSpeedButton;
    bDel: TSpeedButton;
    bSort: TSpeedButton;
    SG: TStringGrid;
    procedure bAddClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Panel1Click(Sender: TObject);
  private

  public

  end;

var
  fMain: TfMain;
  adres: string; //фдрус, откуда запущена программа, что бы потом найти адрес файла с телефонами

implementation

{$R *.lfm}

{ TfMain }

procedure TfMain.FormCreate(Sender: TObject);
begin

end;

procedure TfMain.bAddClick(Sender: TObject);
begin
  //очистка полей
  fEdit.eName.Text:='';
  fEdit.eTelephone.Text:='';
  //modalResult редактора устанавливаем в meNone
  fEdit.ModalResult:= mrNone;
  //выводим форму
  fEdit.ShowModal;
  //если ничего не введено => выход
  if (fEdit.eName.Text='') or (fEdit.eTelephone.Text='') then exit;
  //если не нажал "сохранить" - выходим
  if fEdit.ModalResult <> mrOk then exit;
  //иначе добавляем в сетку "SG" строку, и запоняем её
  SG.RowCount:= SG.RowCount + 1;
  SG.Cells[0, SG.RowCount-1]:= fEdit.eName.Text;
  SG.Cells[1, SG.RowCount-1]:= fEdit.eTelephone.Text;
  SG.Cells[2, SG.RowCount-1]:= fEdit.CBNote.Text;
end;

procedure TfMain.Panel1Click(Sender: TObject);
begin

end;

end.

