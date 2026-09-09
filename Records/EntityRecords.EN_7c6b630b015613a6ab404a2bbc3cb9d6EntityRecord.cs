using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ProposalLine (+b4M+Gpf+kKCL9v+8nyrYA)
///  <code>EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord</code> that represent
/// s <code>ProposalLine</code> <p>Description: Entity that holds Proposal Lines info.</p>
/// </summary>
// Name: ProposalLine
public partial struct EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord : ITypedRecord<EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vObWZSHRu0+xi+vqHUrFEw");
internal static readonly GlobalObjectKey IdProposalId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*GnueM62cmUq0vfqYdx+RBw");
internal static readonly GlobalObjectKey IdApprovalStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*5y7wVo6qQEmLN3RVYJ9mVQ");
internal static readonly GlobalObjectKey IdCompanyId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EtMAknwfQUm5mgbA9ghlSg");
internal static readonly GlobalObjectKey IdSupplierId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Xnlprxzeq0GUfzyHv7fSoQ");
internal static readonly GlobalObjectKey IdFe_contab_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*N9jG4vitOkeU5fwUzPnNVg");
internal static readonly GlobalObjectKey IdEj__mes = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kPHS1olhskyYjMepUeHwcg");
internal static readonly GlobalObjectKey IdCuenta = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*lj89dNsbTkuaZ_AYimHUXQ");
internal static readonly GlobalObjectKey IdReferencia = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Vq8_XX3RFEqz1zQjHLMX_g");
internal static readonly GlobalObjectKey IdNombre1 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kIpDPDqEgk6pqfk4YXidsw");
internal static readonly GlobalObjectKey IdNombre2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*CK0T5o1R4kOizL1ARbQsiQ");
internal static readonly GlobalObjectKey IdN_doc_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ljsUx0iS7EuQbBVwIDEXDw");
internal static readonly GlobalObjectKey IdN_DocType = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*a0xdxt0Wbk+xHgPSo0RPyg");
internal static readonly GlobalObjectKey IdImporteenML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KcmS_EVC8UuJATlX0qd13A");
internal static readonly GlobalObjectKey IdML = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*6Mt9o4wul0OMqEGfdXDqAw");
internal static readonly GlobalObjectKey IdImporteenMD = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ab+y67UPKE2W8qmiF2NfKg");
internal static readonly GlobalObjectKey IdMon_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2+YqsZfpmEKyUg4GLcjR0w");
internal static readonly GlobalObjectKey IdSoc_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kxNPJQ+2l0iq7ADc2FzALg");
internal static readonly GlobalObjectKey IdDiv_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eVNgH8Q5hEentYLEb+uQSQ");
internal static readonly GlobalObjectKey IdLib_mayor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*1NAGz5bVBk2mAvYUm9l0AQ");
internal static readonly GlobalObjectKey IdTextocab_documento = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+DcRnKPDpkmIL4qHSDHdkQ");
internal static readonly GlobalObjectKey IdDoc_comp_ = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hXYQbqn5PUynWybVsoYgTA");
internal static readonly GlobalObjectKey IdPaidBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*P+qvgya6WEWYZ3YXCje6PA");
internal static readonly GlobalObjectKey IdPaidOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MLSrh9aAYU+q6itgT6SesA");
internal static readonly GlobalObjectKey IdUnpaidBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*dnwFMCPVYUiNS9GKwRucNQ");
internal static readonly GlobalObjectKey IdUnpaidOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+4EC6RGRh0aL0PwENPui6g");
internal static readonly GlobalObjectKey IdHasErrors = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*pj3EWCT21USwg6A9LplcUg");
internal static readonly GlobalObjectKey IdErrorMessage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Enq64EQX+EWAbNpl7_lUsg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(28,true);
          _ssId = value;
      }
  }
}

private long _ssProposalId;
public long ssProposalId{
  get{
      return _ssProposalId;
  }
  set{
      if((_ssProposalId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssProposalId = value;
      }
  }
}

private int _ssApprovalStatusId;
public int ssApprovalStatusId{
  get{
      return _ssApprovalStatusId;
  }
  set{
      if((_ssApprovalStatusId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssApprovalStatusId = value;
      }
  }
}

private long _ssCompanyId;
public long ssCompanyId{
  get{
      return _ssCompanyId;
  }
  set{
      if((_ssCompanyId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCompanyId = value;
      }
  }
}

private long _ssSupplierId;
public long ssSupplierId{
  get{
      return _ssSupplierId;
  }
  set{
      if((_ssSupplierId!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssSupplierId = value;
      }
  }
}

private DateTime _ssFe_contab_;
public DateTime ssFe_contab_{
  get{
      return _ssFe_contab_;
  }
  set{
      if((_ssFe_contab_!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssFe_contab_ = value;
      }
  }
}

private string _ssEj__mes;
public string ssEj__mes{
  get{
      return _ssEj__mes;
  }
  set{
      if((_ssEj__mes!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssEj__mes = value;
      }
  }
}

private string _ssCuenta;
public string ssCuenta{
  get{
      return _ssCuenta;
  }
  set{
      if((_ssCuenta!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssCuenta = value;
      }
  }
}

private string _ssReferencia;
public string ssReferencia{
  get{
      return _ssReferencia;
  }
  set{
      if((_ssReferencia!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssReferencia = value;
      }
  }
}

private string _ssNombre1;
public string ssNombre1{
  get{
      return _ssNombre1;
  }
  set{
      if((_ssNombre1!=value) || OptimizedAttributes[9]){
          ChangedAttributes[9] = true;
          _ssNombre1 = value;
      }
  }
}

private string _ssNombre2;
public string ssNombre2{
  get{
      return _ssNombre2;
  }
  set{
      if((_ssNombre2!=value) || OptimizedAttributes[10]){
          ChangedAttributes[10] = true;
          _ssNombre2 = value;
      }
  }
}

private string _ssN_doc_;
public string ssN_doc_{
  get{
      return _ssN_doc_;
  }
  set{
      if((_ssN_doc_!=value) || OptimizedAttributes[11]){
          ChangedAttributes[11] = true;
          _ssN_doc_ = value;
      }
  }
}

private string _ssN_DocType;
public string ssN_DocType{
  get{
      return _ssN_DocType;
  }
  set{
      if((_ssN_DocType!=value) || OptimizedAttributes[12]){
          ChangedAttributes[12] = true;
          _ssN_DocType = value;
      }
  }
}

private decimal _ssImporteenML;
public decimal ssImporteenML{
  get{
      return _ssImporteenML;
  }
  set{
      if((_ssImporteenML!=value) || OptimizedAttributes[13]){
          ChangedAttributes[13] = true;
          _ssImporteenML = value;
      }
  }
}

private string _ssML;
public string ssML{
  get{
      return _ssML;
  }
  set{
      if((_ssML!=value) || OptimizedAttributes[14]){
          ChangedAttributes[14] = true;
          _ssML = value;
      }
  }
}

private decimal _ssImporteenMD;
public decimal ssImporteenMD{
  get{
      return _ssImporteenMD;
  }
  set{
      if((_ssImporteenMD!=value) || OptimizedAttributes[15]){
          ChangedAttributes[15] = true;
          _ssImporteenMD = value;
      }
  }
}

private string _ssMon_;
public string ssMon_{
  get{
      return _ssMon_;
  }
  set{
      if((_ssMon_!=value) || OptimizedAttributes[16]){
          ChangedAttributes[16] = true;
          _ssMon_ = value;
      }
  }
}

private string _ssSoc_;
public string ssSoc_{
  get{
      return _ssSoc_;
  }
  set{
      if((_ssSoc_!=value) || OptimizedAttributes[17]){
          ChangedAttributes[17] = true;
          _ssSoc_ = value;
      }
  }
}

private string _ssDiv_;
public string ssDiv_{
  get{
      return _ssDiv_;
  }
  set{
      if((_ssDiv_!=value) || OptimizedAttributes[18]){
          ChangedAttributes[18] = true;
          _ssDiv_ = value;
      }
  }
}

private string _ssLib_mayor;
public string ssLib_mayor{
  get{
      return _ssLib_mayor;
  }
  set{
      if((_ssLib_mayor!=value) || OptimizedAttributes[19]){
          ChangedAttributes[19] = true;
          _ssLib_mayor = value;
      }
  }
}

private string _ssTextocab_documento;
public string ssTextocab_documento{
  get{
      return _ssTextocab_documento;
  }
  set{
      if((_ssTextocab_documento!=value) || OptimizedAttributes[20]){
          ChangedAttributes[20] = true;
          _ssTextocab_documento = value;
      }
  }
}

private string _ssDoc_comp_;
public string ssDoc_comp_{
  get{
      return _ssDoc_comp_;
  }
  set{
      if((_ssDoc_comp_!=value) || OptimizedAttributes[21]){
          ChangedAttributes[21] = true;
          _ssDoc_comp_ = value;
      }
  }
}

private string _ssPaidBy;
public string ssPaidBy{
  get{
      return _ssPaidBy;
  }
  set{
      if((_ssPaidBy!=value) || OptimizedAttributes[22]){
          ChangedAttributes[22] = true;
          _ssPaidBy = value;
      }
  }
}

private DateTime _ssPaidOn;
public DateTime ssPaidOn{
  get{
      return _ssPaidOn;
  }
  set{
      if((_ssPaidOn!=value) || OptimizedAttributes[23]){
          ChangedAttributes[23] = true;
          _ssPaidOn = value;
      }
  }
}

private string _ssUnpaidBy;
public string ssUnpaidBy{
  get{
      return _ssUnpaidBy;
  }
  set{
      if((_ssUnpaidBy!=value) || OptimizedAttributes[24]){
          ChangedAttributes[24] = true;
          _ssUnpaidBy = value;
      }
  }
}

private DateTime _ssUnpaidOn;
public DateTime ssUnpaidOn{
  get{
      return _ssUnpaidOn;
  }
  set{
      if((_ssUnpaidOn!=value) || OptimizedAttributes[25]){
          ChangedAttributes[25] = true;
          _ssUnpaidOn = value;
      }
  }
}

private bool _ssHasErrors;
public bool ssHasErrors{
  get{
      return _ssHasErrors;
  }
  set{
      if((_ssHasErrors!=value) || OptimizedAttributes[26]){
          ChangedAttributes[26] = true;
          _ssHasErrors = value;
      }
  }
}

private string _ssErrorMessage;
public string ssErrorMessage{
  get{
      return _ssErrorMessage;
  }
  set{
      if((_ssErrorMessage!=value) || OptimizedAttributes[27]){
          ChangedAttributes[27] = true;
          _ssErrorMessage = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord() {
ChangedAttributes = new BitArray(28,true);
OptimizedAttributes = new BitArray(28,false);
_ssId = 0L;
_ssProposalId = 0L;
_ssApprovalStatusId = 0;
_ssCompanyId = 0L;
_ssSupplierId = 0L;
_ssFe_contab_ = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssEj__mes = "";
_ssCuenta = "";
_ssReferencia = "";
_ssNombre1 = "";
_ssNombre2 = "";
_ssN_doc_ = "";
_ssN_DocType = "";
_ssImporteenML = 0.0M;
_ssML = "";
_ssImporteenMD = 0.0M;
_ssMon_ = "";
_ssSoc_ = "";
_ssDiv_ = "";
_ssLib_mayor = "";
_ssTextocab_documento = "";
_ssDoc_comp_ = "";
_ssPaidBy = "";
_ssPaidOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUnpaidBy = "";
_ssUnpaidOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssHasErrors = false;
_ssErrorMessage = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssId = r.ReadLongInteger(index++, "ProposalLine.Id", 0L);
ssProposalId = r.ReadEntityReferenceLongInteger(index++, "ProposalLine.ProposalId", 0L);
ssApprovalStatusId = r.ReadEntityReference(index++, "ProposalLine.ApprovalStatusId", 0);
ssCompanyId = r.ReadEntityReferenceLongInteger(index++, "ProposalLine.CompanyId", 0L);
ssSupplierId = r.ReadEntityReferenceLongInteger(index++, "ProposalLine.SupplierId", 0L);
ssFe_contab_ = r.ReadDate(index++, "ProposalLine.Fe_contab_", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssEj__mes = r.ReadText(index++, "ProposalLine.Ej__mes", "");
ssCuenta = r.ReadText(index++, "ProposalLine.Cuenta", "");
ssReferencia = r.ReadText(index++, "ProposalLine.Referencia", "");
ssNombre1 = r.ReadText(index++, "ProposalLine.Nombre1", "");
ssNombre2 = r.ReadText(index++, "ProposalLine.Nombre2", "");
ssN_doc_ = r.ReadText(index++, "ProposalLine.N_doc_", "");
ssN_DocType = r.ReadText(index++, "ProposalLine.N_DocType", "");
ssImporteenML = r.ReadDecimal(index++, "ProposalLine.ImporteenML", 0.0M);
ssML = r.ReadText(index++, "ProposalLine.ML", "");
ssImporteenMD = r.ReadDecimal(index++, "ProposalLine.ImporteenMD", 0.0M);
ssMon_ = r.ReadText(index++, "ProposalLine.Mon_", "");
ssSoc_ = r.ReadText(index++, "ProposalLine.Soc_", "");
ssDiv_ = r.ReadText(index++, "ProposalLine.Div_", "");
ssLib_mayor = r.ReadText(index++, "ProposalLine.Lib_mayor", "");
ssTextocab_documento = r.ReadText(index++, "ProposalLine.Textocab_documento", "");
ssDoc_comp_ = r.ReadText(index++, "ProposalLine.Doc_comp_", "");
ssPaidBy = r.ReadEntityReferenceText(index++, "ProposalLine.PaidBy", "");
ssPaidOn = r.ReadDateTime(index++, "ProposalLine.PaidOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUnpaidBy = r.ReadEntityReferenceText(index++, "ProposalLine.UnpaidBy", "");
ssUnpaidOn = r.ReadDateTime(index++, "ProposalLine.UnpaidOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssHasErrors = r.ReadBoolean(index++, "ProposalLine.HasErrors", false);
ssErrorMessage = r.ReadText(index++, "ProposalLine.ErrorMessage", "");
ChangedAttributes = new BitArray(28,false);
OptimizedAttributes = new BitArray(28,false);
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord r) {
this = r;
}


public static bool operator == (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord a, EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssProposalId != b.ssProposalId) return false;
if (a.ssApprovalStatusId != b.ssApprovalStatusId) return false;
if (a.ssCompanyId != b.ssCompanyId) return false;
if (a.ssSupplierId != b.ssSupplierId) return false;
if (a.ssFe_contab_ != b.ssFe_contab_) return false;
if (a.ssEj__mes != b.ssEj__mes) return false;
if (a.ssCuenta != b.ssCuenta) return false;
if (a.ssReferencia != b.ssReferencia) return false;
if (a.ssNombre1 != b.ssNombre1) return false;
if (a.ssNombre2 != b.ssNombre2) return false;
if (a.ssN_doc_ != b.ssN_doc_) return false;
if (a.ssN_DocType != b.ssN_DocType) return false;
if (a.ssImporteenML != b.ssImporteenML) return false;
if (a.ssML != b.ssML) return false;
if (a.ssImporteenMD != b.ssImporteenMD) return false;
if (a.ssMon_ != b.ssMon_) return false;
if (a.ssSoc_ != b.ssSoc_) return false;
if (a.ssDiv_ != b.ssDiv_) return false;
if (a.ssLib_mayor != b.ssLib_mayor) return false;
if (a.ssTextocab_documento != b.ssTextocab_documento) return false;
if (a.ssDoc_comp_ != b.ssDoc_comp_) return false;
if (a.ssPaidBy != b.ssPaidBy) return false;
if (a.ssPaidOn != b.ssPaidOn) return false;
if (a.ssUnpaidBy != b.ssUnpaidBy) return false;
if (a.ssUnpaidOn != b.ssUnpaidOn) return false;
if (a.ssHasErrors != b.ssHasErrors) return false;
if (a.ssErrorMessage != b.ssErrorMessage) return false;
return true;
}

public static bool operator != (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord a, EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord)) return false;
return (this == (EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssProposalId.GetHashCode()
 ^ ssApprovalStatusId.GetHashCode()
 ^ ssCompanyId.GetHashCode()
 ^ ssSupplierId.GetHashCode()
 ^ ssFe_contab_.GetHashCode()
 ^ ssEj__mes.GetHashCode()
 ^ ssCuenta.GetHashCode()
 ^ ssReferencia.GetHashCode()
 ^ ssNombre1.GetHashCode()
 ^ ssNombre2.GetHashCode()
 ^ ssN_doc_.GetHashCode()
 ^ ssN_DocType.GetHashCode()
 ^ ssImporteenML.GetHashCode()
 ^ ssML.GetHashCode()
 ^ ssImporteenMD.GetHashCode()
 ^ ssMon_.GetHashCode()
 ^ ssSoc_.GetHashCode()
 ^ ssDiv_.GetHashCode()
 ^ ssLib_mayor.GetHashCode()
 ^ ssTextocab_documento.GetHashCode()
 ^ ssDoc_comp_.GetHashCode()
 ^ ssPaidBy.GetHashCode()
 ^ ssPaidOn.GetHashCode()
 ^ ssUnpaidBy.GetHashCode()
 ^ ssUnpaidOn.GetHashCode()
 ^ ssHasErrors.GetHashCode()
 ^ ssErrorMessage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord Duplicate() {
EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord t;
t._ssId = this._ssId;
t._ssProposalId = this._ssProposalId;
t._ssApprovalStatusId = this._ssApprovalStatusId;
t._ssCompanyId = this._ssCompanyId;
t._ssSupplierId = this._ssSupplierId;
t._ssFe_contab_ = this._ssFe_contab_;
t._ssEj__mes = this._ssEj__mes;
t._ssCuenta = this._ssCuenta;
t._ssReferencia = this._ssReferencia;
t._ssNombre1 = this._ssNombre1;
t._ssNombre2 = this._ssNombre2;
t._ssN_doc_ = this._ssN_doc_;
t._ssN_DocType = this._ssN_DocType;
t._ssImporteenML = this._ssImporteenML;
t._ssML = this._ssML;
t._ssImporteenMD = this._ssImporteenMD;
t._ssMon_ = this._ssMon_;
t._ssSoc_ = this._ssSoc_;
t._ssDiv_ = this._ssDiv_;
t._ssLib_mayor = this._ssLib_mayor;
t._ssTextocab_documento = this._ssTextocab_documento;
t._ssDoc_comp_ = this._ssDoc_comp_;
t._ssPaidBy = this._ssPaidBy;
t._ssPaidOn = this._ssPaidOn;
t._ssUnpaidBy = this._ssUnpaidBy;
t._ssUnpaidOn = this._ssUnpaidOn;
t._ssHasErrors = this._ssHasErrors;
t._ssErrorMessage = this._ssErrorMessage;
t.ChangedAttributes = new BitArray(28);
t.OptimizedAttributes = new BitArray(28);
for(int i = 0; i < 28; i++){
  t.ChangedAttributes[i] = ChangedAttributes[i];
  t.OptimizedAttributes[i] = OptimizedAttributes[i];
}
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "proposalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProposalId")) variable.Value = ssProposalId; else variable.Optimized = true;
} else if (head == "approvalstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApprovalStatusId")) variable.Value = ssApprovalStatusId; else variable.Optimized = true;
} else if (head == "companyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyId")) variable.Value = ssCompanyId; else variable.Optimized = true;
} else if (head == "supplierid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierId")) variable.Value = ssSupplierId; else variable.Optimized = true;
} else if (head == "fe_contab_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Fe_contab_")) variable.Value = ssFe_contab_; else variable.Optimized = true;
} else if (head == "ej__mes") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Ej__mes")) variable.Value = ssEj__mes; else variable.Optimized = true;
} else if (head == "cuenta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Cuenta")) variable.Value = ssCuenta; else variable.Optimized = true;
} else if (head == "referencia") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Referencia")) variable.Value = ssReferencia; else variable.Optimized = true;
} else if (head == "nombre1") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Nombre1")) variable.Value = ssNombre1; else variable.Optimized = true;
} else if (head == "nombre2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Nombre2")) variable.Value = ssNombre2; else variable.Optimized = true;
} else if (head == "n_doc_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".N_doc_")) variable.Value = ssN_doc_; else variable.Optimized = true;
} else if (head == "n_doctype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".N_DocType")) variable.Value = ssN_DocType; else variable.Optimized = true;
} else if (head == "importeenml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImporteenML")) variable.Value = ssImporteenML; else variable.Optimized = true;
} else if (head == "ml") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ML")) variable.Value = ssML; else variable.Optimized = true;
} else if (head == "importeenmd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ImporteenMD")) variable.Value = ssImporteenMD; else variable.Optimized = true;
} else if (head == "mon_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Mon_")) variable.Value = ssMon_; else variable.Optimized = true;
} else if (head == "soc_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Soc_")) variable.Value = ssSoc_; else variable.Optimized = true;
} else if (head == "div_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Div_")) variable.Value = ssDiv_; else variable.Optimized = true;
} else if (head == "lib_mayor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Lib_mayor")) variable.Value = ssLib_mayor; else variable.Optimized = true;
} else if (head == "textocab_documento") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Textocab_documento")) variable.Value = ssTextocab_documento; else variable.Optimized = true;
} else if (head == "doc_comp_") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Doc_comp_")) variable.Value = ssDoc_comp_; else variable.Optimized = true;
} else if (head == "paidby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaidBy")) variable.Value = ssPaidBy; else variable.Optimized = true;
} else if (head == "paidon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaidOn")) variable.Value = ssPaidOn; else variable.Optimized = true;
} else if (head == "unpaidby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnpaidBy")) variable.Value = ssUnpaidBy; else variable.Optimized = true;
} else if (head == "unpaidon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UnpaidOn")) variable.Value = ssUnpaidOn; else variable.Optimized = true;
} else if (head == "haserrors") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".HasErrors")) variable.Value = ssHasErrors; else variable.Optimized = true;
} else if (head == "errormessage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ErrorMessage")) variable.Value = ssErrorMessage; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdProposalId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdApprovalStatusId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCompanyId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdSupplierId)) {
return ChangedAttributes[4];
}
if (key.Equals(IdFe_contab_)) {
return ChangedAttributes[5];
}
if (key.Equals(IdEj__mes)) {
return ChangedAttributes[6];
}
if (key.Equals(IdCuenta)) {
return ChangedAttributes[7];
}
if (key.Equals(IdReferencia)) {
return ChangedAttributes[8];
}
if (key.Equals(IdNombre1)) {
return ChangedAttributes[9];
}
if (key.Equals(IdNombre2)) {
return ChangedAttributes[10];
}
if (key.Equals(IdN_doc_)) {
return ChangedAttributes[11];
}
if (key.Equals(IdN_DocType)) {
return ChangedAttributes[12];
}
if (key.Equals(IdImporteenML)) {
return ChangedAttributes[13];
}
if (key.Equals(IdML)) {
return ChangedAttributes[14];
}
if (key.Equals(IdImporteenMD)) {
return ChangedAttributes[15];
}
if (key.Equals(IdMon_)) {
return ChangedAttributes[16];
}
if (key.Equals(IdSoc_)) {
return ChangedAttributes[17];
}
if (key.Equals(IdDiv_)) {
return ChangedAttributes[18];
}
if (key.Equals(IdLib_mayor)) {
return ChangedAttributes[19];
}
if (key.Equals(IdTextocab_documento)) {
return ChangedAttributes[20];
}
if (key.Equals(IdDoc_comp_)) {
return ChangedAttributes[21];
}
if (key.Equals(IdPaidBy)) {
return ChangedAttributes[22];
}
if (key.Equals(IdPaidOn)) {
return ChangedAttributes[23];
}
if (key.Equals(IdUnpaidBy)) {
return ChangedAttributes[24];
}
if (key.Equals(IdUnpaidOn)) {
return ChangedAttributes[25];
}
if (key.Equals(IdHasErrors)) {
return ChangedAttributes[26];
}
if (key.Equals(IdErrorMessage)) {
return ChangedAttributes[27];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdProposalId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdApprovalStatusId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCompanyId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdSupplierId)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdFe_contab_)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdEj__mes)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdCuenta)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdReferencia)) {
return OptimizedAttributes[8];
}
if (key.Equals(IdNombre1)) {
return OptimizedAttributes[9];
}
if (key.Equals(IdNombre2)) {
return OptimizedAttributes[10];
}
if (key.Equals(IdN_doc_)) {
return OptimizedAttributes[11];
}
if (key.Equals(IdN_DocType)) {
return OptimizedAttributes[12];
}
if (key.Equals(IdImporteenML)) {
return OptimizedAttributes[13];
}
if (key.Equals(IdML)) {
return OptimizedAttributes[14];
}
if (key.Equals(IdImporteenMD)) {
return OptimizedAttributes[15];
}
if (key.Equals(IdMon_)) {
return OptimizedAttributes[16];
}
if (key.Equals(IdSoc_)) {
return OptimizedAttributes[17];
}
if (key.Equals(IdDiv_)) {
return OptimizedAttributes[18];
}
if (key.Equals(IdLib_mayor)) {
return OptimizedAttributes[19];
}
if (key.Equals(IdTextocab_documento)) {
return OptimizedAttributes[20];
}
if (key.Equals(IdDoc_comp_)) {
return OptimizedAttributes[21];
}
if (key.Equals(IdPaidBy)) {
return OptimizedAttributes[22];
}
if (key.Equals(IdPaidOn)) {
return OptimizedAttributes[23];
}
if (key.Equals(IdUnpaidBy)) {
return OptimizedAttributes[24];
}
if (key.Equals(IdUnpaidOn)) {
return OptimizedAttributes[25];
}
if (key.Equals(IdHasErrors)) {
return OptimizedAttributes[26];
}
if (key.Equals(IdErrorMessage)) {
return OptimizedAttributes[27];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdProposalId) {
return ssProposalId;
}
if (key == IdApprovalStatusId) {
return ssApprovalStatusId;
}
if (key == IdCompanyId) {
return ssCompanyId;
}
if (key == IdSupplierId) {
return ssSupplierId;
}
if (key == IdFe_contab_) {
return ssFe_contab_;
}
if (key == IdEj__mes) {
return ssEj__mes;
}
if (key == IdCuenta) {
return ssCuenta;
}
if (key == IdReferencia) {
return ssReferencia;
}
if (key == IdNombre1) {
return ssNombre1;
}
if (key == IdNombre2) {
return ssNombre2;
}
if (key == IdN_doc_) {
return ssN_doc_;
}
if (key == IdN_DocType) {
return ssN_DocType;
}
if (key == IdImporteenML) {
return ssImporteenML;
}
if (key == IdML) {
return ssML;
}
if (key == IdImporteenMD) {
return ssImporteenMD;
}
if (key == IdMon_) {
return ssMon_;
}
if (key == IdSoc_) {
return ssSoc_;
}
if (key == IdDiv_) {
return ssDiv_;
}
if (key == IdLib_mayor) {
return ssLib_mayor;
}
if (key == IdTextocab_documento) {
return ssTextocab_documento;
}
if (key == IdDoc_comp_) {
return ssDoc_comp_;
}
if (key == IdPaidBy) {
return ssPaidBy;
}
if (key == IdPaidOn) {
return ssPaidOn;
}
if (key == IdUnpaidBy) {
return ssUnpaidBy;
}
if (key == IdUnpaidOn) {
return ssUnpaidOn;
}
if (key == IdHasErrors) {
return ssHasErrors;
}
if (key == IdErrorMessage) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdProposalId.Key.AsGuid) {
return ssProposalId;
}
if (attributeKey == IdApprovalStatusId.Key.AsGuid) {
return ssApprovalStatusId;
}
if (attributeKey == IdCompanyId.Key.AsGuid) {
return ssCompanyId;
}
if (attributeKey == IdSupplierId.Key.AsGuid) {
return ssSupplierId;
}
if (attributeKey == IdFe_contab_.Key.AsGuid) {
return ssFe_contab_;
}
if (attributeKey == IdEj__mes.Key.AsGuid) {
return ssEj__mes;
}
if (attributeKey == IdCuenta.Key.AsGuid) {
return ssCuenta;
}
if (attributeKey == IdReferencia.Key.AsGuid) {
return ssReferencia;
}
if (attributeKey == IdNombre1.Key.AsGuid) {
return ssNombre1;
}
if (attributeKey == IdNombre2.Key.AsGuid) {
return ssNombre2;
}
if (attributeKey == IdN_doc_.Key.AsGuid) {
return ssN_doc_;
}
if (attributeKey == IdN_DocType.Key.AsGuid) {
return ssN_DocType;
}
if (attributeKey == IdImporteenML.Key.AsGuid) {
return ssImporteenML;
}
if (attributeKey == IdML.Key.AsGuid) {
return ssML;
}
if (attributeKey == IdImporteenMD.Key.AsGuid) {
return ssImporteenMD;
}
if (attributeKey == IdMon_.Key.AsGuid) {
return ssMon_;
}
if (attributeKey == IdSoc_.Key.AsGuid) {
return ssSoc_;
}
if (attributeKey == IdDiv_.Key.AsGuid) {
return ssDiv_;
}
if (attributeKey == IdLib_mayor.Key.AsGuid) {
return ssLib_mayor;
}
if (attributeKey == IdTextocab_documento.Key.AsGuid) {
return ssTextocab_documento;
}
if (attributeKey == IdDoc_comp_.Key.AsGuid) {
return ssDoc_comp_;
}
if (attributeKey == IdPaidBy.Key.AsGuid) {
return ssPaidBy;
}
if (attributeKey == IdPaidOn.Key.AsGuid) {
return ssPaidOn;
}
if (attributeKey == IdUnpaidBy.Key.AsGuid) {
return ssUnpaidBy;
}
if (attributeKey == IdUnpaidOn.Key.AsGuid) {
return ssUnpaidOn;
}
if (attributeKey == IdHasErrors.Key.AsGuid) {
return ssHasErrors;
}
if (attributeKey == IdErrorMessage.Key.AsGuid) {
return ssErrorMessage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(28);
OptimizedAttributes = new BitArray(28);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssProposalId = (long) other.AttributeGet(IdProposalId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdProposalId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdProposalId);
ssApprovalStatusId = (int) other.AttributeGet(IdApprovalStatusId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdApprovalStatusId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdApprovalStatusId);
ssCompanyId = (long) other.AttributeGet(IdCompanyId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCompanyId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCompanyId);
ssSupplierId = (long) other.AttributeGet(IdSupplierId);
ChangedAttributes[4] = other.ChangedAttributeGet(IdSupplierId);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdSupplierId);
ssFe_contab_ = (DateTime) other.AttributeGet(IdFe_contab_);
ChangedAttributes[5] = other.ChangedAttributeGet(IdFe_contab_);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdFe_contab_);
ssEj__mes = (string) other.AttributeGet(IdEj__mes);
ChangedAttributes[6] = other.ChangedAttributeGet(IdEj__mes);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdEj__mes);
ssCuenta = (string) other.AttributeGet(IdCuenta);
ChangedAttributes[7] = other.ChangedAttributeGet(IdCuenta);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdCuenta);
ssReferencia = (string) other.AttributeGet(IdReferencia);
ChangedAttributes[8] = other.ChangedAttributeGet(IdReferencia);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdReferencia);
ssNombre1 = (string) other.AttributeGet(IdNombre1);
ChangedAttributes[9] = other.ChangedAttributeGet(IdNombre1);
OptimizedAttributes[9] = other.OptimizedAttributeGet(IdNombre1);
ssNombre2 = (string) other.AttributeGet(IdNombre2);
ChangedAttributes[10] = other.ChangedAttributeGet(IdNombre2);
OptimizedAttributes[10] = other.OptimizedAttributeGet(IdNombre2);
ssN_doc_ = (string) other.AttributeGet(IdN_doc_);
ChangedAttributes[11] = other.ChangedAttributeGet(IdN_doc_);
OptimizedAttributes[11] = other.OptimizedAttributeGet(IdN_doc_);
ssN_DocType = (string) other.AttributeGet(IdN_DocType);
ChangedAttributes[12] = other.ChangedAttributeGet(IdN_DocType);
OptimizedAttributes[12] = other.OptimizedAttributeGet(IdN_DocType);
ssImporteenML = (decimal) other.AttributeGet(IdImporteenML);
ChangedAttributes[13] = other.ChangedAttributeGet(IdImporteenML);
OptimizedAttributes[13] = other.OptimizedAttributeGet(IdImporteenML);
ssML = (string) other.AttributeGet(IdML);
ChangedAttributes[14] = other.ChangedAttributeGet(IdML);
OptimizedAttributes[14] = other.OptimizedAttributeGet(IdML);
ssImporteenMD = (decimal) other.AttributeGet(IdImporteenMD);
ChangedAttributes[15] = other.ChangedAttributeGet(IdImporteenMD);
OptimizedAttributes[15] = other.OptimizedAttributeGet(IdImporteenMD);
ssMon_ = (string) other.AttributeGet(IdMon_);
ChangedAttributes[16] = other.ChangedAttributeGet(IdMon_);
OptimizedAttributes[16] = other.OptimizedAttributeGet(IdMon_);
ssSoc_ = (string) other.AttributeGet(IdSoc_);
ChangedAttributes[17] = other.ChangedAttributeGet(IdSoc_);
OptimizedAttributes[17] = other.OptimizedAttributeGet(IdSoc_);
ssDiv_ = (string) other.AttributeGet(IdDiv_);
ChangedAttributes[18] = other.ChangedAttributeGet(IdDiv_);
OptimizedAttributes[18] = other.OptimizedAttributeGet(IdDiv_);
ssLib_mayor = (string) other.AttributeGet(IdLib_mayor);
ChangedAttributes[19] = other.ChangedAttributeGet(IdLib_mayor);
OptimizedAttributes[19] = other.OptimizedAttributeGet(IdLib_mayor);
ssTextocab_documento = (string) other.AttributeGet(IdTextocab_documento);
ChangedAttributes[20] = other.ChangedAttributeGet(IdTextocab_documento);
OptimizedAttributes[20] = other.OptimizedAttributeGet(IdTextocab_documento);
ssDoc_comp_ = (string) other.AttributeGet(IdDoc_comp_);
ChangedAttributes[21] = other.ChangedAttributeGet(IdDoc_comp_);
OptimizedAttributes[21] = other.OptimizedAttributeGet(IdDoc_comp_);
ssPaidBy = (string) other.AttributeGet(IdPaidBy);
ChangedAttributes[22] = other.ChangedAttributeGet(IdPaidBy);
OptimizedAttributes[22] = other.OptimizedAttributeGet(IdPaidBy);
ssPaidOn = (DateTime) other.AttributeGet(IdPaidOn);
ChangedAttributes[23] = other.ChangedAttributeGet(IdPaidOn);
OptimizedAttributes[23] = other.OptimizedAttributeGet(IdPaidOn);
ssUnpaidBy = (string) other.AttributeGet(IdUnpaidBy);
ChangedAttributes[24] = other.ChangedAttributeGet(IdUnpaidBy);
OptimizedAttributes[24] = other.OptimizedAttributeGet(IdUnpaidBy);
ssUnpaidOn = (DateTime) other.AttributeGet(IdUnpaidOn);
ChangedAttributes[25] = other.ChangedAttributeGet(IdUnpaidOn);
OptimizedAttributes[25] = other.OptimizedAttributeGet(IdUnpaidOn);
ssHasErrors = (bool) other.AttributeGet(IdHasErrors);
ChangedAttributes[26] = other.ChangedAttributeGet(IdHasErrors);
OptimizedAttributes[26] = other.OptimizedAttributeGet(IdHasErrors);
ssErrorMessage = (string) other.AttributeGet(IdErrorMessage);
ChangedAttributes[27] = other.ChangedAttributeGet(IdErrorMessage);
OptimizedAttributes[27] = other.OptimizedAttributeGet(IdErrorMessage);
}
} // EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord

/// <summary>
/// RecordList type <code>ProposalLineList</code> that represents a record list of
///  <code>ProposalLine</code>
/// </summary>
public partial class RL_aa6d551b6d5a88ffd31c1dc552b78a0a : GenericRecordList<EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord>, IEnumerable, IEnumerator {

protected override EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord GetElementDefaultValue() {
return new EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
}

public T[] ToArray<T>(Func<EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aa6d551b6d5a88ffd31c1dc552b78a0a recordList, Func<EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aa6d551b6d5a88ffd31c1dc552b78a0a(EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord[] array) {
  RL_aa6d551b6d5a88ffd31c1dc552b78a0a result = new RL_aa6d551b6d5a88ffd31c1dc552b78a0a();
result.InnerFromArray(array);
    return result;
}

public static RL_aa6d551b6d5a88ffd31c1dc552b78a0a ToList<T>(T[] array, Func <T, EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord> converter) {
  RL_aa6d551b6d5a88ffd31c1dc552b78a0a result = new RL_aa6d551b6d5a88ffd31c1dc552b78a0a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aa6d551b6d5a88ffd31c1dc552b78a0a FromRestList<T>(RestList<T> restList, Func <T, EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord> converter) {
  RL_aa6d551b6d5a88ffd31c1dc552b78a0a result = new RL_aa6d551b6d5a88ffd31c1dc552b78a0a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aa6d551b6d5a88ffd31c1dc552b78a0a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord> NewList() {
return new RL_aa6d551b6d5a88ffd31c1dc552b78a0a();
}


} // RL_aa6d551b6d5a88ffd31c1dc552b78a0a
}
