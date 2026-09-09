using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] TaxIndicator (y1nHtqvgrEGoys3jJ4K+oA)
///  <code>EN_efc751d189a1545503ba31ced5225e86EntityRecord</code> that represent
/// s <code>TaxIndicator</code> <p>Description: Entity holds tax indicators.</p>
/// </summary>
// Name: TaxIndicator
public partial struct EN_efc751d189a1545503ba31ced5225e86EntityRecord : ITypedRecord<EN_efc751d189a1545503ba31ced5225e86EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*OqjW+hlPzUe6Q1s+reEHgQ");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*XsSttd7DrU2fvi2K9vB_oA");
internal static readonly GlobalObjectKey IdExternalId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*8p4PaslMXEKMqtgtFZ76ig");
internal static readonly GlobalObjectKey IdCreatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*B9SJDBefik6lq5xYR2Ra4g");
internal static readonly GlobalObjectKey IdCreatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*jnNpGSO510+NzGpQY+rmhw");
internal static readonly GlobalObjectKey IdUpdatedOn = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Ysac_np1jUCKYDA9_4q7PA");
internal static readonly GlobalObjectKey IdUpdatedBy = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*D0kQC97ZMEm2NrpgJ2Y7rQ");

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

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssDescription = value;
      }
  }
}

private string _ssExternalId;
public string ssExternalId{
  get{
      return _ssExternalId;
  }
  set{
      if((_ssExternalId!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssExternalId = value;
      }
  }
}

private DateTime _ssCreatedOn;
public DateTime ssCreatedOn{
  get{
      return _ssCreatedOn;
  }
  set{
      if((_ssCreatedOn!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
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
      if((_ssCreatedBy!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssUpdatedOn!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
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
      if((_ssUpdatedBy!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssUpdatedBy = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_efc751d189a1545503ba31ced5225e86EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssId = 0L;
_ssDescription = "";
_ssExternalId = "";
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
ssId = r.ReadLongInteger(index++, "TaxIndicator.Id", 0L);
ssDescription = r.ReadText(index++, "TaxIndicator.Description", "");
ssExternalId = r.ReadText(index++, "TaxIndicator.ExternalId", "");
ssCreatedOn = r.ReadDateTime(index++, "TaxIndicator.CreatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssCreatedBy = r.ReadEntityReferenceText(index++, "TaxIndicator.CreatedBy", "");
ssUpdatedOn = r.ReadDateTime(index++, "TaxIndicator.UpdatedOn", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
ssUpdatedBy = r.ReadEntityReferenceText(index++, "TaxIndicator.UpdatedBy", "");
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
public void ReadIM(EN_efc751d189a1545503ba31ced5225e86EntityRecord r) {
this = r;
}


public static bool operator == (EN_efc751d189a1545503ba31ced5225e86EntityRecord a, EN_efc751d189a1545503ba31ced5225e86EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssExternalId != b.ssExternalId) return false;
if (a.ssCreatedOn != b.ssCreatedOn) return false;
if (a.ssCreatedBy != b.ssCreatedBy) return false;
if (a.ssUpdatedOn != b.ssUpdatedOn) return false;
if (a.ssUpdatedBy != b.ssUpdatedBy) return false;
return true;
}

public static bool operator != (EN_efc751d189a1545503ba31ced5225e86EntityRecord a, EN_efc751d189a1545503ba31ced5225e86EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_efc751d189a1545503ba31ced5225e86EntityRecord)) return false;
return (this == (EN_efc751d189a1545503ba31ced5225e86EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssExternalId.GetHashCode()
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


public EN_efc751d189a1545503ba31ced5225e86EntityRecord Duplicate() {
EN_efc751d189a1545503ba31ced5225e86EntityRecord t;
t._ssId = this._ssId;
t._ssDescription = this._ssDescription;
t._ssExternalId = this._ssExternalId;
t._ssCreatedOn = this._ssCreatedOn;
t._ssCreatedBy = this._ssCreatedBy;
t._ssUpdatedOn = this._ssUpdatedOn;
t._ssUpdatedBy = this._ssUpdatedBy;
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
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "externalid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ExternalId")) variable.Value = ssExternalId; else variable.Optimized = true;
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
if (key.Equals(IdDescription)) {
return ChangedAttributes[1];
}
if (key.Equals(IdExternalId)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return ChangedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return ChangedAttributes[4];
}
if (key.Equals(IdUpdatedOn)) {
return ChangedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdDescription)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdExternalId)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCreatedOn)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdCreatedBy)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdUpdatedOn)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdUpdatedBy)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdDescription) {
return ssDescription;
}
if (key == IdExternalId) {
return ssExternalId;
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
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdExternalId.Key.AsGuid) {
return ssExternalId;
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
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[1] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdDescription);
ssExternalId = (string) other.AttributeGet(IdExternalId);
ChangedAttributes[2] = other.ChangedAttributeGet(IdExternalId);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdExternalId);
ssCreatedOn = (DateTime) other.AttributeGet(IdCreatedOn);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCreatedOn);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCreatedOn);
ssCreatedBy = (string) other.AttributeGet(IdCreatedBy);
ChangedAttributes[4] = other.ChangedAttributeGet(IdCreatedBy);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdCreatedBy);
ssUpdatedOn = (DateTime) other.AttributeGet(IdUpdatedOn);
ChangedAttributes[5] = other.ChangedAttributeGet(IdUpdatedOn);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdUpdatedOn);
ssUpdatedBy = (string) other.AttributeGet(IdUpdatedBy);
ChangedAttributes[6] = other.ChangedAttributeGet(IdUpdatedBy);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdUpdatedBy);
}
} // EN_efc751d189a1545503ba31ced5225e86EntityRecord

/// <summary>
/// RecordList type <code>TaxIndicatorList</code> that represents a record list of
///  <code>TaxIndicator</code>
/// </summary>
public partial class RL_e59aecfdbe31bd20a1b7b65d4a8119b4 : GenericRecordList<EN_efc751d189a1545503ba31ced5225e86EntityRecord>, IEnumerable, IEnumerator {

protected override EN_efc751d189a1545503ba31ced5225e86EntityRecord GetElementDefaultValue() {
return new EN_efc751d189a1545503ba31ced5225e86EntityRecord();
}

public T[] ToArray<T>(Func<EN_efc751d189a1545503ba31ced5225e86EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e59aecfdbe31bd20a1b7b65d4a8119b4 recordList, Func<EN_efc751d189a1545503ba31ced5225e86EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e59aecfdbe31bd20a1b7b65d4a8119b4(EN_efc751d189a1545503ba31ced5225e86EntityRecord[] array) {
  RL_e59aecfdbe31bd20a1b7b65d4a8119b4 result = new RL_e59aecfdbe31bd20a1b7b65d4a8119b4();
result.InnerFromArray(array);
    return result;
}

public static RL_e59aecfdbe31bd20a1b7b65d4a8119b4 ToList<T>(T[] array, Func <T, EN_efc751d189a1545503ba31ced5225e86EntityRecord> converter) {
  RL_e59aecfdbe31bd20a1b7b65d4a8119b4 result = new RL_e59aecfdbe31bd20a1b7b65d4a8119b4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e59aecfdbe31bd20a1b7b65d4a8119b4 FromRestList<T>(RestList<T> restList, Func <T, EN_efc751d189a1545503ba31ced5225e86EntityRecord> converter) {
  RL_e59aecfdbe31bd20a1b7b65d4a8119b4 result = new RL_e59aecfdbe31bd20a1b7b65d4a8119b4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e59aecfdbe31bd20a1b7b65d4a8119b4() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_efc751d189a1545503ba31ced5225e86EntityRecord> NewList() {
return new RL_e59aecfdbe31bd20a1b7b65d4a8119b4();
}


} // RL_e59aecfdbe31bd20a1b7b65d4a8119b4
}
