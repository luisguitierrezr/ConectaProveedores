using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] InvoiceAccountingProcess (WMrlupySo0O5h8hgm+X47w)
///  <code>EN_d21666375df829d28ffce8e5e0a3400dEntityRecord</code> that represent
/// s <code>InvoiceAccountingProcess</code> <p>Description: Process created to call Invoice
///  Accounting</p>
/// </summary>
// Name: InvoiceAccountingProcess
public partial struct EN_d21666375df829d28ffce8e5e0a3400dEntityRecord : ITypedRecord<EN_d21666375df829d28ffce8e5e0a3400dEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*21zez0nz7UaslblaqOpInQ");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*vw8zHwsTDUOo1B96Zl_LHA");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*JZpDH8AdIkSLqHa5W__qRA");
internal static readonly GlobalObjectKey IdOffsetUtc = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IgLoL9zz3Eu4V0yqbtY2Pw");
internal static readonly GlobalObjectKey IdComment = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NkZYs97c5Emgxzxr_zmNsg");
internal static readonly GlobalObjectKey IdProcessNumber = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*rg2tswFmDEufYbI16m6jdA");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Y2MMF7hdiESotUWrb2LnEg");
internal static readonly GlobalObjectKey IdNextTry = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*24JRNpUha0KCMKfEUN7WAg");
internal static readonly GlobalObjectKey IdInvoiceProcessStatusId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*wEjqh6caHk643Wcpw4avTg");

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

private long _ssInvoiceId;
public long ssInvoiceId{
  get{
      return _ssInvoiceId;
  }
  set{
      if((_ssInvoiceId!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssInvoiceId = value;
      }
  }
}

private long _ssRequisitionId;
public long ssRequisitionId{
  get{
      return _ssRequisitionId;
  }
  set{
      if((_ssRequisitionId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssRequisitionId = value;
      }
  }
}

private int _ssOffsetUtc;
public int ssOffsetUtc{
  get{
      return _ssOffsetUtc;
  }
  set{
      if((_ssOffsetUtc!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssOffsetUtc = value;
      }
  }
}

private string _ssComment;
public string ssComment{
  get{
      return _ssComment;
  }
  set{
      if((_ssComment!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssComment = value;
      }
  }
}

private int _ssProcessNumber;
public int ssProcessNumber{
  get{
      return _ssProcessNumber;
  }
  set{
      if((_ssProcessNumber!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssProcessNumber = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssCreatedOn = value;
      }
  }
}

private int _ssNextTry;
public int ssNextTry{
  get{
      return _ssNextTry;
  }
  set{
      if((_ssNextTry!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssNextTry = value;
      }
  }
}

private int _ssInvoiceProcessStatusId;
public int ssInvoiceProcessStatusId{
  get{
      return _ssInvoiceProcessStatusId;
  }
  set{
      if((_ssInvoiceProcessStatusId!=value) || OptimizedAttributes[8]){
          ChangedAttributes[8] = true;
          _ssInvoiceProcessStatusId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord() {
ChangedAttributes = new BitArray(9,true);
OptimizedAttributes = new BitArray(9,false);
_ssId = 0L;
_ssInvoiceId = 0L;
_ssRequisitionId = 0L;
_ssOffsetUtc = 0;
_ssComment = "";
_ssProcessNumber = 0;
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssNextTry = 1;
_ssInvoiceProcessStatusId = 0;
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
ssId = r.ReadLongInteger(index++, "InvoiceAccountingProcess.Id", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingProcess.InvoiceId", 0L);
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "InvoiceAccountingProcess.RequisitionId", 0L);
ssOffsetUtc = r.ReadInteger(index++, "InvoiceAccountingProcess.OffsetUtc", 0);
ssComment = r.ReadText(index++, "InvoiceAccountingProcess.Comment", "");
ssProcessNumber = r.ReadInteger(index++, "InvoiceAccountingProcess.ProcessNumber", 0);
ssCreatedOn = r.ReadDateTime(index++, "InvoiceAccountingProcess.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssNextTry = r.ReadInteger(index++, "InvoiceAccountingProcess.NextTry", 1);
ssInvoiceProcessStatusId = r.ReadEntityReference(index++, "InvoiceAccountingProcess.InvoiceProcessStatusId", 0);
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
public void ReadIM(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord r) {
this = r;
}


public static bool operator == (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord a, EN_d21666375df829d28ffce8e5e0a3400dEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssOffsetUtc != b.ssOffsetUtc) return false;
if (a.ssComment != b.ssComment) return false;
if (a.ssProcessNumber != b.ssProcessNumber) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssNextTry != b.ssNextTry) return false;
if (a.ssInvoiceProcessStatusId != b.ssInvoiceProcessStatusId) return false;
return true;
}

public static bool operator != (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord a, EN_d21666375df829d28ffce8e5e0a3400dEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord)) return false;
return (this == (EN_d21666375df829d28ffce8e5e0a3400dEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssOffsetUtc.GetHashCode()
 ^ ssComment.GetHashCode()
 ^ ssProcessNumber.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssNextTry.GetHashCode()
 ^ ssInvoiceProcessStatusId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord Duplicate() {
EN_d21666375df829d28ffce8e5e0a3400dEntityRecord t;
t._ssId = this._ssId;
t._ssInvoiceId = this._ssInvoiceId;
t._ssRequisitionId = this._ssRequisitionId;
t._ssOffsetUtc = this._ssOffsetUtc;
t._ssComment = this._ssComment;
t._ssProcessNumber = this._ssProcessNumber;
t._ssCreatedOn = this._ssCreatedOn;
t._ssNextTry = this._ssNextTry;
t._ssInvoiceProcessStatusId = this._ssInvoiceProcessStatusId;
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
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "requisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionId")) variable.Value = ssRequisitionId; else variable.Optimized = true;
} else if (head == "offsetutc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OffsetUtc")) variable.Value = ssOffsetUtc; else variable.Optimized = true;
} else if (head == "comment") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Comment")) variable.Value = ssComment; else variable.Optimized = true;
} else if (head == "processnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessNumber")) variable.Value = ssProcessNumber; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "nexttry") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NextTry")) variable.Value = ssNextTry; else variable.Optimized = true;
} else if (head == "invoiceprocessstatusid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceProcessStatusId")) variable.Value = ssInvoiceProcessStatusId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return ChangedAttributes[1];
}
if (key.Equals(IdRequisitionId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdOffsetUtc)) {
return ChangedAttributes[3];
}
if (key.Equals(IdComment)) {
return ChangedAttributes[4];
}
if (key.Equals(IdProcessNumber)) {
return ChangedAttributes[5];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[6];
}
if (key.Equals(IdNextTry)) {
return ChangedAttributes[7];
}
if (key.Equals(IdInvoiceProcessStatusId)) {
return ChangedAttributes[8];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdInvoiceId)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdRequisitionId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdOffsetUtc)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdComment)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdProcessNumber)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdNextTry)) {
return OptimizedAttributes[7];
}
if (key.Equals(IdInvoiceProcessStatusId)) {
return OptimizedAttributes[8];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdRequisitionId) {
return ssRequisitionId;
}
if (key == IdOffsetUtc) {
return ssOffsetUtc;
}
if (key == IdComment) {
return ssComment;
}
if (key == IdProcessNumber) {
return ssProcessNumber;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdNextTry) {
return ssNextTry;
}
if (key == IdInvoiceProcessStatusId) {
return ssInvoiceProcessStatusId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdRequisitionId.Key.AsGuid) {
return ssRequisitionId;
}
if (attributeKey == IdOffsetUtc.Key.AsGuid) {
return ssOffsetUtc;
}
if (attributeKey == IdComment.Key.AsGuid) {
return ssComment;
}
if (attributeKey == IdProcessNumber.Key.AsGuid) {
return ssProcessNumber;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdNextTry.Key.AsGuid) {
return ssNextTry;
}
if (attributeKey == IdInvoiceProcessStatusId.Key.AsGuid) {
return ssInvoiceProcessStatusId;
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
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ChangedAttributes[1] = other.ChangedAttributeGet(IdInvoiceId);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdInvoiceId);
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdRequisitionId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdRequisitionId);
ssOffsetUtc = (int) other.AttributeGet(IdOffsetUtc);
ChangedAttributes[3] = other.ChangedAttributeGet(IdOffsetUtc);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOffsetUtc);
ssComment = (string) other.AttributeGet(IdComment);
ChangedAttributes[4] = other.ChangedAttributeGet(IdComment);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdComment);
ssProcessNumber = (int) other.AttributeGet(IdProcessNumber);
ChangedAttributes[5] = other.ChangedAttributeGet(IdProcessNumber);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdProcessNumber);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[6] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdCreatedOn);
ssNextTry = (int) other.AttributeGet(IdNextTry);
ChangedAttributes[7] = other.ChangedAttributeGet(IdNextTry);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdNextTry);
ssInvoiceProcessStatusId = (int) other.AttributeGet(IdInvoiceProcessStatusId);
ChangedAttributes[8] = other.ChangedAttributeGet(IdInvoiceProcessStatusId);
OptimizedAttributes[8] = other.OptimizedAttributeGet(IdInvoiceProcessStatusId);
}
} // EN_d21666375df829d28ffce8e5e0a3400dEntityRecord

/// <summary>
/// RecordList type <code>InvoiceAccountingProcessList</code> that represents a record list of
///  <code>InvoiceAccountingProcess</code>
/// </summary>
public partial class RL_937087d6dad996b13202e68f8faa450a : GenericRecordList<EN_d21666375df829d28ffce8e5e0a3400dEntityRecord>, IEnumerable, IEnumerator {

protected override EN_d21666375df829d28ffce8e5e0a3400dEntityRecord GetElementDefaultValue() {
return new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();
}

public T[] ToArray<T>(Func<EN_d21666375df829d28ffce8e5e0a3400dEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_937087d6dad996b13202e68f8faa450a recordList, Func<EN_d21666375df829d28ffce8e5e0a3400dEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_937087d6dad996b13202e68f8faa450a(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord[] array) {
  RL_937087d6dad996b13202e68f8faa450a result = new RL_937087d6dad996b13202e68f8faa450a();
result.InnerFromArray(array);
    return result;
}

public static RL_937087d6dad996b13202e68f8faa450a ToList<T>(T[] array, Func <T, EN_d21666375df829d28ffce8e5e0a3400dEntityRecord> converter) {
  RL_937087d6dad996b13202e68f8faa450a result = new RL_937087d6dad996b13202e68f8faa450a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_937087d6dad996b13202e68f8faa450a FromRestList<T>(RestList<T> restList, Func <T, EN_d21666375df829d28ffce8e5e0a3400dEntityRecord> converter) {
  RL_937087d6dad996b13202e68f8faa450a result = new RL_937087d6dad996b13202e68f8faa450a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_937087d6dad996b13202e68f8faa450a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_d21666375df829d28ffce8e5e0a3400dEntityRecord> NewList() {
return new RL_937087d6dad996b13202e68f8faa450a();
}


} // RL_937087d6dad996b13202e68f8faa450a
}
