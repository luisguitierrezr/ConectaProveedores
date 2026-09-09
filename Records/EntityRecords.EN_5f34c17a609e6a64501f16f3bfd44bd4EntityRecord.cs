using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] LogsAccounting (fDxiNYXmuEuiqmOvcEAYdA)
///  <code>EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord</code> that represent
/// s <code>LogsAccounting</code> <p>Description: </p>
/// </summary>
// Name: LogsAccounting
public partial struct EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord : ITypedRecord<EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kkAPhzrJVECjgU5t7Xyluw");
internal static readonly GlobalObjectKey IdTitle = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*EnC0pSJD4EOa3fLe6R6pkg");
internal static readonly GlobalObjectKey IdAssociatedId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*n9xgCWC43EaxwJbYN2KWAg");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*nq0+1u2H8kSqAhiWALQH1A");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Vqd8sNYFAEqSvcsRAbZQ8A");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UvYhW4BUjUy8CAfavYq56Q");
internal static readonly GlobalObjectKey IdLogsAccountingSubjectId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kW3zM3AJekScBBC2neWdUg");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(7,true);
          _ssId = value;
      }
  }
}

private string _ssTitle;
public string ssTitle{
  get{
      return _ssTitle;
  }
  set{
      if((_ssTitle!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssTitle = value;
      }
  }
}

private string _ssAssociatedId;
public string ssAssociatedId{
  get{
      return _ssAssociatedId;
  }
  set{
      if((_ssAssociatedId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssAssociatedId = value;
      }
  }
}

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssDescription = value;
      }
  }
}

private string _ssCreatedBy;
public string ssCreatedBy{
  get{
      return _ssCreatedBy;
  }
  set{
      if((_ssCreatedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssCreatedBy = value;
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

private int _ssLogsAccountingSubjectId;
public int ssLogsAccountingSubjectId{
  get{
      return _ssLogsAccountingSubjectId;
  }
  set{
      if((_ssLogsAccountingSubjectId!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssLogsAccountingSubjectId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssTitle = "";
_ssAssociatedId = "";
_ssDescription = "";
_ssCreatedBy = "";
_ssCreatedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
_ssLogsAccountingSubjectId = 0;
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
ssId = r.ReadLongInteger(index++, "LogsAccounting.Id", 0L);
ssTitle = r.ReadText(index++, "LogsAccounting.Title", "");
ssAssociatedId = r.ReadText(index++, "LogsAccounting.AssociatedId", "");
ssDescription = r.ReadText(index++, "LogsAccounting.Description", "");
ssCreatedBy = r.ReadEntityReferenceText(index++, "LogsAccounting.CreatedBy", "");
ssCreatedOn = r.ReadDateTime(index++, "LogsAccounting.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssLogsAccountingSubjectId = r.ReadEntityReference(index++, "LogsAccounting.LogsAccountingSubjectId", 0);
ChangedAttributes = new BitArray(7,false);
OptimizedAttributes = new BitArray(7,false);
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
public void ReadIM(EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord r) {
this = r;
}


public static bool operator == (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord a, EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssTitle != b.ssTitle) return false;
if (a.ssAssociatedId != b.ssAssociatedId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssLogsAccountingSubjectId != b.ssLogsAccountingSubjectId) return false;
return true;
}

public static bool operator != (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord a, EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord)) return false;
return (this == (EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssTitle.GetHashCode()
 ^ ssAssociatedId.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssCreatedBy.GetHashCode()
 ^ ssCreatedOn.GetHashCode()
 ^ ssLogsAccountingSubjectId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord Duplicate() {
EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord t;
t._ssId = this._ssId;
t._ssTitle = this._ssTitle;
t._ssAssociatedId = this._ssAssociatedId;
t._ssDescription = this._ssDescription;
t._ssCreatedBy = this._ssCreatedBy;
t._ssCreatedOn = this._ssCreatedOn;
t._ssLogsAccountingSubjectId = this._ssLogsAccountingSubjectId;
t.ChangedAttributes = new BitArray(7);
t.OptimizedAttributes = new BitArray(7);
for(int i = 0; i < 7; i++){
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
} else if (head == "title") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Title")) variable.Value = ssTitle; else variable.Optimized = true;
} else if (head == "associatedid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AssociatedId")) variable.Value = ssAssociatedId; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "createdby") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedBy")) variable.Value = ssCreatedBy; else variable.Optimized = true;
} else if (head == "createdon") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CreatedOn")) variable.Value = ssCreatedOn; else variable.Optimized = true;
} else if (head == "logsaccountingsubjectid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LogsAccountingSubjectId")) variable.Value = ssLogsAccountingSubjectId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdTitle)) {
return ChangedAttributes[1];
}
if (key.Equals(IdAssociatedId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdLogsAccountingSubjectId)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdTitle)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdAssociatedId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdLogsAccountingSubjectId)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdTitle) {
return ssTitle;
}
if (key == IdAssociatedId) {
return ssAssociatedId;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdCreatedBy) {
return ssCreatedBy;
}
if (key == IdCreatedOn) {
return ssCreatedOn;
}
if (key == IdLogsAccountingSubjectId) {
return ssLogsAccountingSubjectId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdTitle.Key.AsGuid) {
return ssTitle;
}
if (attributeKey == IdAssociatedId.Key.AsGuid) {
return ssAssociatedId;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdCreatedBy.Key.AsGuid) {
return ssCreatedBy;
}
if (attributeKey == IdCreatedOn.Key.AsGuid) {
return ssCreatedOn;
}
if (attributeKey == IdLogsAccountingSubjectId.Key.AsGuid) {
return ssLogsAccountingSubjectId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssTitle = (string) other.AttributeGet(IdTitle);
ChangedAttributes[1] = other.ChangedAttributeGet(IdTitle);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdTitle);
ssAssociatedId = (string) other.AttributeGet(IdAssociatedId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdAssociatedId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdAssociatedId);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[3] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdDescription);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdCreatedOn);
ssLogsAccountingSubjectId = (int) other.AttributeGet(IdLogsAccountingSubjectId);
ChangedAttributes[6] = other.ChangedAttributeGet(IdLogsAccountingSubjectId);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdLogsAccountingSubjectId);
}
} // EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord

/// <summary>
/// RecordList type <code>LogsAccountingList</code> that represents a record list of
///  <code>LogsAccounting</code>
/// </summary>
public partial class RL_7e40229a2569b885b826693f59efb874 : GenericRecordList<EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord>, IEnumerable, IEnumerator {

protected override EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord GetElementDefaultValue() {
return new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord();
}

public T[] ToArray<T>(Func<EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7e40229a2569b885b826693f59efb874 recordList, Func<EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7e40229a2569b885b826693f59efb874(EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord[] array) {
  RL_7e40229a2569b885b826693f59efb874 result = new RL_7e40229a2569b885b826693f59efb874();
result.InnerFromArray(array);
    return result;
}

public static RL_7e40229a2569b885b826693f59efb874 ToList<T>(T[] array, Func <T, EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord> converter) {
  RL_7e40229a2569b885b826693f59efb874 result = new RL_7e40229a2569b885b826693f59efb874();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7e40229a2569b885b826693f59efb874 FromRestList<T>(RestList<T> restList, Func <T, EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord> converter) {
  RL_7e40229a2569b885b826693f59efb874 result = new RL_7e40229a2569b885b826693f59efb874();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7e40229a2569b885b826693f59efb874() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord> NewList() {
return new RL_7e40229a2569b885b826693f59efb874();
}


} // RL_7e40229a2569b885b826693f59efb874
}
