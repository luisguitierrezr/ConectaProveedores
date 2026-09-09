using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceAccountingProcessResponse (yheOU1QXwEiSEzqtEJnlzg)
///  <code>EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord</code> that represent
/// s <code>InvoiceAccountingProcessResponse</code> <p>Description: Response after Invoice
///  Accounting</p>
/// </summary>
// Name: InvoiceAccountingProcessResponse
public partial struct EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord : ITypedRecord<EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord> {
internal static readonly GlobalObjectKey IdInvoiceAccountingProcessId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*svkhGbQHF0aZ+reEvFEbZA");
internal static readonly GlobalObjectKey IdIsSuccess = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*odqMaOS9_USETcENDCdIqQ");
internal static readonly GlobalObjectKey IdID_POLIZA = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Ta78xVGvZU2viHVOUZfBWA");
internal static readonly GlobalObjectKey IdTEXTO = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3Mwc69XyXE+kB35wj5N4Mg");
internal static readonly GlobalObjectKey IdPO_RESULTADO = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*7bNyJOpjD0irawaeagDpVg");
internal static readonly GlobalObjectKey IdCODIGO = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*XBMjjRs9AkWtdJ_lw9e5rA");

private long _ssInvoiceAccountingProcessId;
public long ssInvoiceAccountingProcessId{
  get{
      return _ssInvoiceAccountingProcessId;
  }
  set{
      if((_ssInvoiceAccountingProcessId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(6,true);
          _ssInvoiceAccountingProcessId = value;
      }
  }
}

private bool _ssIsSuccess;
public bool ssIsSuccess{
  get{
      return _ssIsSuccess;
  }
  set{
      if((_ssIsSuccess!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssIsSuccess = value;
      }
  }
}

private string _ssID_POLIZA;
public string ssID_POLIZA{
  get{
      return _ssID_POLIZA;
  }
  set{
      if((_ssID_POLIZA!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssID_POLIZA = value;
      }
  }
}

private string _ssTEXTO;
public string ssTEXTO{
  get{
      return _ssTEXTO;
  }
  set{
      if((_ssTEXTO!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssTEXTO = value;
      }
  }
}

private string _ssPO_RESULTADO;
public string ssPO_RESULTADO{
  get{
      return _ssPO_RESULTADO;
  }
  set{
      if((_ssPO_RESULTADO!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssPO_RESULTADO = value;
      }
  }
}

private string _ssCODIGO;
public string ssCODIGO{
  get{
      return _ssCODIGO;
  }
  set{
      if((_ssCODIGO!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCODIGO = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssInvoiceAccountingProcessId = 0L;
_ssIsSuccess = false;
_ssID_POLIZA = "";
_ssTEXTO = "";
_ssPO_RESULTADO = "";
_ssCODIGO = "";
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
ssInvoiceAccountingProcessId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingProcessResponse.InvoiceAccountingProcessId", 0L);
ssIsSuccess = r.ReadBoolean(index++, "InvoiceAccountingProcessResponse.IsSuccess", false);
ssID_POLIZA = r.ReadText(index++, "InvoiceAccountingProcessResponse.ID_POLIZA", "");
ssTEXTO = r.ReadText(index++, "InvoiceAccountingProcessResponse.TEXTO", "");
ssPO_RESULTADO = r.ReadText(index++, "InvoiceAccountingProcessResponse.PO_RESULTADO", "");
ssCODIGO = r.ReadText(index++, "InvoiceAccountingProcessResponse.CODIGO", "");
ChangedAttributes = new BitArray(6,false);
OptimizedAttributes = new BitArray(6,false);
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
public void ReadIM(EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord r) {
this = r;
}


public static bool operator == (EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord a, EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord b) {
if (a.ssInvoiceAccountingProcessId != b.ssInvoiceAccountingProcessId) return false;
if (a.ssIsSuccess != b.ssIsSuccess) return false;
if (a.ssID_POLIZA != b.ssID_POLIZA) return false;
if (a.ssTEXTO != b.ssTEXTO) return false;
if (a.ssPO_RESULTADO != b.ssPO_RESULTADO) return false;
if (a.ssCODIGO != b.ssCODIGO) return false;
return true;
}

public static bool operator != (EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord a, EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord)) return false;
return (this == (EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceAccountingProcessId.GetHashCode()
 ^ ssIsSuccess.GetHashCode()
 ^ ssID_POLIZA.GetHashCode()
 ^ ssTEXTO.GetHashCode()
 ^ ssPO_RESULTADO.GetHashCode()
 ^ ssCODIGO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord Duplicate() {
EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord t;
t._ssInvoiceAccountingProcessId = this._ssInvoiceAccountingProcessId;
t._ssIsSuccess = this._ssIsSuccess;
t._ssID_POLIZA = this._ssID_POLIZA;
t._ssTEXTO = this._ssTEXTO;
t._ssPO_RESULTADO = this._ssPO_RESULTADO;
t._ssCODIGO = this._ssCODIGO;
t.ChangedAttributes = new BitArray(6);
t.OptimizedAttributes = new BitArray(6);
for(int i = 0; i < 6; i++){
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
if (head == "invoiceaccountingprocessid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingProcessId")) variable.Value = ssInvoiceAccountingProcessId; else variable.Optimized = true;
} else if (head == "issuccess") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSuccess")) variable.Value = ssIsSuccess; else variable.Optimized = true;
} else if (head == "id_poliza") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ID_POLIZA")) variable.Value = ssID_POLIZA; else variable.Optimized = true;
} else if (head == "texto") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO")) variable.Value = ssTEXTO; else variable.Optimized = true;
} else if (head == "po_resultado") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_RESULTADO")) variable.Value = ssPO_RESULTADO; else variable.Optimized = true;
} else if (head == "codigo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CODIGO")) variable.Value = ssCODIGO; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdInvoiceAccountingProcessId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdIsSuccess)) {
return ChangedAttributes[1];
}
if (key.Equals(IdID_POLIZA)) {
return ChangedAttributes[2];
}
if (key.Equals(IdTEXTO)) {
return ChangedAttributes[3];
}
if (key.Equals(IdPO_RESULTADO)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCODIGO)) {
return ChangedAttributes[5];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdInvoiceAccountingProcessId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdIsSuccess)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdID_POLIZA)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdTEXTO)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdPO_RESULTADO)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCODIGO)) {
return OptimizedAttributes[5];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccountingProcessId) {
return ssInvoiceAccountingProcessId;
}
if (key == IdIsSuccess) {
return ssIsSuccess;
}
if (key == IdID_POLIZA) {
return ssID_POLIZA;
}
if (key == IdTEXTO) {
return ssTEXTO;
}
if (key == IdPO_RESULTADO) {
return ssPO_RESULTADO;
}
if (key == IdCODIGO) {
return ssCODIGO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingProcessId.Key.AsGuid) {
return ssInvoiceAccountingProcessId;
}
if (attributeKey == IdIsSuccess.Key.AsGuid) {
return ssIsSuccess;
}
if (attributeKey == IdID_POLIZA.Key.AsGuid) {
return ssID_POLIZA;
}
if (attributeKey == IdTEXTO.Key.AsGuid) {
return ssTEXTO;
}
if (attributeKey == IdPO_RESULTADO.Key.AsGuid) {
return ssPO_RESULTADO;
}
if (attributeKey == IdCODIGO.Key.AsGuid) {
return ssCODIGO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(6);
OptimizedAttributes = new BitArray(6);
if (other == null) return;
ssInvoiceAccountingProcessId = (long) other.AttributeGet(IdInvoiceAccountingProcessId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdInvoiceAccountingProcessId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdInvoiceAccountingProcessId);
ssIsSuccess = (bool) other.AttributeGet(IdIsSuccess);
ChangedAttributes[1] = other.ChangedAttributeGet(IdIsSuccess);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdIsSuccess);
ssID_POLIZA = (string) other.AttributeGet(IdID_POLIZA);
ChangedAttributes[2] = other.ChangedAttributeGet(IdID_POLIZA);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdID_POLIZA);
ssTEXTO = (string) other.AttributeGet(IdTEXTO);
ChangedAttributes[3] = other.ChangedAttributeGet(IdTEXTO);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdTEXTO);
ssPO_RESULTADO = (string) other.AttributeGet(IdPO_RESULTADO);
ChangedAttributes[4] = other.ChangedAttributeGet(IdPO_RESULTADO);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdPO_RESULTADO);
ssCODIGO = (string) other.AttributeGet(IdCODIGO);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCODIGO);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCODIGO);
}
} // EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord

/// <summary>
/// RecordList type <code>InvoiceAccountingProcessResponseList</code> that represents a record list of
///  <code>InvoiceAccountingProcessResponse</code>
/// </summary>
public partial class RL_e35b79dd2adf29f756ff8cbe8d3b76f4 : GenericRecordList<EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord>, IEnumerable, IEnumerator {

protected override EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord GetElementDefaultValue() {
return new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord();
}

public T[] ToArray<T>(Func<EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e35b79dd2adf29f756ff8cbe8d3b76f4 recordList, Func<EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e35b79dd2adf29f756ff8cbe8d3b76f4(EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord[] array) {
  RL_e35b79dd2adf29f756ff8cbe8d3b76f4 result = new RL_e35b79dd2adf29f756ff8cbe8d3b76f4();
result.InnerFromArray(array);
    return result;
}

public static RL_e35b79dd2adf29f756ff8cbe8d3b76f4 ToList<T>(T[] array, Func <T, EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord> converter) {
  RL_e35b79dd2adf29f756ff8cbe8d3b76f4 result = new RL_e35b79dd2adf29f756ff8cbe8d3b76f4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e35b79dd2adf29f756ff8cbe8d3b76f4 FromRestList<T>(RestList<T> restList, Func <T, EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord> converter) {
  RL_e35b79dd2adf29f756ff8cbe8d3b76f4 result = new RL_e35b79dd2adf29f756ff8cbe8d3b76f4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e35b79dd2adf29f756ff8cbe8d3b76f4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord> NewList() {
return new RL_e35b79dd2adf29f756ff8cbe8d3b76f4();
}


} // RL_e35b79dd2adf29f756ff8cbe8d3b76f4
}
