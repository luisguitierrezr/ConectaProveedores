using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] FiscalYearExceptions (+JnDnY3Cg0yu3k1oVjEx6A)
///  <code>EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord</code> that represent
/// s <code>FiscalYearExceptions</code> <p>Description: </p>
/// </summary>
// Name: FiscalYearExceptions
public partial struct EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord : ITypedRecord<EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*8wS+DiGEV0iZtzDpkvsdsw");
internal static readonly GlobalObjectKey IdYear = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*cUAG3cNgAkWy_gC702FgXA");
internal static readonly GlobalObjectKey IdInvoiceFolio = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*ie5uFlIrEkS9KbKkCurBSQ");
internal static readonly GlobalObjectKey IdInvoiceUUID = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*u45Gww_ip0GSQZcsrnLerw");
internal static readonly GlobalObjectKey IdIsActive = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*TrRnd1MN90mFyy7UeuxgSw");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*uE9zJF1G2EOTOGl3pV6p5Q");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Aqxu3BKy0Uu5rY1C2Tk4TA");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*p28CL9Ce6ke3X1IwUYToWA");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*DGrrW9y920esmmxOOYMLEg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(9,true);
          _ssId = value;
      }
  }
}

private int _ssYear;
public int ssYear{
  get{
      return _ssYear;
  }
  set{
      if((_ssYear!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssYear = value;
      }
  }
}

private string _ssInvoiceFolio;
public string ssInvoiceFolio{
  get{
      return _ssInvoiceFolio;
  }
  set{
      if((_ssInvoiceFolio!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssInvoiceFolio = value;
      }
  }
}

private string _ssInvoiceUUID;
public string ssInvoiceUUID{
  get{
      return _ssInvoiceUUID;
  }
  set{
      if((_ssInvoiceUUID!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssInvoiceUUID = value;
      }
  }
}

private bool _ssIsActive;
public bool ssIsActive{
  get{
      return _ssIsActive;
  }
  set{
      if((_ssIsActive!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIsActive = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssCreatedOn = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCreatedBy = value;
      }
  }
}

private DateTime _ssUpdatedOn;
public DateTime ssUpdatedOn{
  get{
      return _ssUpdatedOn;
  }
  set{
      if((_ssUpdatedOn!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssUpdatedOn = value;
      }
  }
}

private string _ssUpdatedBy;
public string ssUpdatedBy{
  get{
      return _ssUpdatedBy;
  }
  set{
      if((_ssUpdatedBy!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord() {
ChangedAttributes = new BitArray(9,true);
OptimizedAttributes = new BitArray(9,false);
_ssId = 0L;
_ssYear = 0;
_ssInvoiceFolio = "";
_ssInvoiceUUID = "";
_ssIsActive = false;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssCreatedBy = "";
_ssUpdatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssUpdatedBy = "";
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
ssId = r.ReadLongInteger(index++, "FiscalYearExceptions.Id", 0L);
ssYear = r.ReadInteger(index++, "FiscalYearExceptions.Year", 0);
ssInvoiceFolio = r.ReadText(index++, "FiscalYearExceptions.InvoiceFolio", "");
ssInvoiceUUID = r.ReadText(index++, "FiscalYearExceptions.InvoiceUUID", "");
ssIsActive = r.ReadBoolean(index++, "FiscalYearExceptions.IsActive", false);
ssCreatedOn = r.ReadDateTime(index++, "FiscalYearExceptions.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "FiscalYearExceptions.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "FiscalYearExceptions.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "FiscalYearExceptions.UpdatedBy", "");
ChangedAttributes = new BitArray(9,false);
OptimizedAttributes = new BitArray(9,false);
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
public void ReadIM(EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord r) {
this = r;
}


public static bool operator == (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord a, EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssYear != b.ssYear) return false;
if (a.ssInvoiceFolio != b.ssInvoiceFolio) return false;
if (a.ssInvoiceUUID != b.ssInvoiceUUID) return false;
if (a.ssIsActive != b.ssIsActive) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord a, EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord)) return false;
return (this == (EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssYear.GetHashCode()
 ^ ssInvoiceFolio.GetHashCode()
 ^ ssInvoiceUUID.GetHashCode()
 ^ ssIsActive.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssUpdatedOn.GetHashCode()
 ^ ssUpdatedBy.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord Duplicate() {
EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord t;
t._ssId = this._ssId;
t._ssYear = this._ssYear;
t._ssInvoiceFolio = this._ssInvoiceFolio;
t._ssInvoiceUUID = this._ssInvoiceUUID;
t._ssIsActive = this._ssIsActive;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
t.ChangedAttributes = new BitArray(9);
t.OptimizedAttributes = new BitArray(9);
for(int i = 0; i < 9; i++){
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
} else if (head == "year") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Year")) variable.Value = ssYear; else variable.Optimized = true;
} else if (head == "invoicefolio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFolio")) variable.Value = ssInvoiceFolio; else variable.Optimized = true;
} else if (head == "invoiceuuid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUUID")) variable.Value = ssInvoiceUUID; else variable.Optimized = true;
} else if (head == "isactive") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsActive")) variable.Value = ssIsActive; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "updatedon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedOn")) variable.Value = ssUpdatedOn; else variable.Optimized = true;
} else if (head == "updatedby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UpdatedBy")) variable.Value = ssUpdatedBy; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdYear)) {
return ChangedAttributes[1];
}
if (key.Equals(IdInvoiceFolio)) {
return ChangedAttributes[2];
}
if (key.Equals(IdInvoiceUUID)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsActive)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[6];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[7];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[8];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdYear)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdInvoiceFolio)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdInvoiceUUID)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsActive)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[8];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdYear) {
return ssYear;
}
if (key == IdInvoiceFolio) {
return ssInvoiceFolio;
}
if (key == IdInvoiceUUID) {
return ssInvoiceUUID;
}
if (key == IdIsActive) {
return ssIsActive;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdUpdatedOn) {
return ssUpdatedOn;
}
if (key == IdUpdatedBy) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdYear.Key.AsGuid) {
return ssYear;
}
if (attributeKey == IdInvoiceFolio.Key.AsGuid) {
return ssInvoiceFolio;
}
if (attributeKey == IdInvoiceUUID.Key.AsGuid) {
return ssInvoiceUUID;
}
if (attributeKey == IdIsActive.Key.AsGuid) {
return ssIsActive;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdUpdatedOn.Key.AsGuid) {
return ssUpdatedOn;
}
if (attributeKey == IdUpdatedBy.Key.AsGuid) {
return ssUpdatedBy;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(9);
OptimizedAttributes = new BitArray(9);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssYear = (int) other.AttributeGet(IdYear);
ChangedAttributes[1] = other.ChangedAttributeGet(IdYear);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdYear);
ssInvoiceFolio = (string) other.AttributeGet(IdInvoiceFolio);
ChangedAttributes[2] = other.ChangedAttributeGet(IdInvoiceFolio);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdInvoiceFolio);
ssInvoiceUUID = (string) other.AttributeGet(IdInvoiceUUID);
ChangedAttributes[3] = other.ChangedAttributeGet(IdInvoiceUUID);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdInvoiceUUID);
ssIsActive = (bool) other.AttributeGet(IdIsActive);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsActive);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsActive);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[7] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[8] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord

/// <summary>
/// RecordList type <code>FiscalYearExceptionsList</code> that represents a record list of
///  <code>FiscalYearExceptions</code>
/// </summary>
public partial class RL_ebb8764b02d33d3775e7fcb6e7806b8a : GenericRecordList<EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord>, IEnumerable, IEnumerator {

protected override EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord GetElementDefaultValue() {
return new EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord();
}

public T[] ToArray<T>(Func<EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ebb8764b02d33d3775e7fcb6e7806b8a recordList, Func<EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ebb8764b02d33d3775e7fcb6e7806b8a(EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord[] array) {
  RL_ebb8764b02d33d3775e7fcb6e7806b8a result = new RL_ebb8764b02d33d3775e7fcb6e7806b8a();
result.InnerFromArray(array);
    return result;
}

public static RL_ebb8764b02d33d3775e7fcb6e7806b8a ToList<T>(T[] array, Func <T, EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord> converter) {
  RL_ebb8764b02d33d3775e7fcb6e7806b8a result = new RL_ebb8764b02d33d3775e7fcb6e7806b8a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ebb8764b02d33d3775e7fcb6e7806b8a FromRestList<T>(RestList<T> restList, Func <T, EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord> converter) {
  RL_ebb8764b02d33d3775e7fcb6e7806b8a result = new RL_ebb8764b02d33d3775e7fcb6e7806b8a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ebb8764b02d33d3775e7fcb6e7806b8a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord> NewList() {
return new RL_ebb8764b02d33d3775e7fcb6e7806b8a();
}


} // RL_ebb8764b02d33d3775e7fcb6e7806b8a
}
