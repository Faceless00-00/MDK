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

procedure TfMain.Panel1Click(Sender: TObject);
begin

end;

end.

