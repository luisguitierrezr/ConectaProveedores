using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] ColumnSettings (unRGEm2Bf0ST5hVARClOFQ)
///  <code>EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord</code> that represent
/// s <code>ColumnSettings</code> <p>Description: Entity that holds the Column Organizer Settings.</p>
/// </summary>
// Name: ColumnSettings
public partial struct EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord : ITypedRecord<EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*MZjPksNBWU+Y4w0yEYWeBA");
internal static readonly GlobalObjectKey IdTableName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*fmaV9nd4xkagnDBGLRhPtw");
internal static readonly GlobalObjectKey IdJSONData = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*M6gCkW6BYEWGI02g9wkc9Q");
internal static readonly GlobalObjectKey IdUserId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ar3MUJ6j5kyJwpUwrRLicQ");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(4,true);
          _ssId = value;
      }
  }
}

private string _ssTableName;
public string ssTableName{
  get{
      return _ssTableName;
  }
  set{
      if((_ssTableName!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssTableName = value;
      }
  }
}

private byte[] _ssJSONData;
public byte[] ssJSONData{
  get{
      return _ssJSONData;
  }
  set{
      if((_ssJSONData!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssJSONData = value;
      }
  }
}

private string _ssUserId;
public string ssUserId{
  get{
      return _ssUserId;
  }
  set{
      if((_ssUserId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssUserId = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord() {
ChangedAttributes = new BitArray(4,true);
OptimizedAttributes = new BitArray(4,false);
_ssId = 0L;
_ssTableName = "";
_ssJSONData = new byte[] {};
_ssUserId = "";
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
ssId = r.ReadLongInteger(index++, "ColumnSettings.Id", 0L);
ssTableName = r.ReadText(index++, "ColumnSettings.TableName", "");
ssJSONData = r.ReadBinaryData(index++, "ColumnSettings.JSONData", new byte[] {});
ssUserId = r.ReadEntityReferenceText(index++, "ColumnSettings.UserId", "");
ChangedAttributes = new BitArray(4,false);
OptimizedAttributes = new BitArray(4,false);
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
public void ReadIM(EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord r) {
this = r;
}


public static bool operator == (EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord a, EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssTableName != b.ssTableName) return false;
if (!RuntimePlatformUtils.CompareByteArrays(a.ssJSONData, b.ssJSONData)) return false;
if (a.ssUserId != b.ssUserId) return false;
return true;
}

public static bool operator != (EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord a, EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord)) return false;
return (this == (EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssTableName.GetHashCode()
 ^ ssJSONData.GetHashCode()
 ^ ssUserId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord Duplicate() {
EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord t;
t._ssId = this._ssId;
t._ssTableName = this._ssTableName;
t._ssJSONData = this._ssJSONData;
t._ssUserId = this._ssUserId;
t.ChangedAttributes = new BitArray(4);
t.OptimizedAttributes = new BitArray(4);
for(int i = 0; i < 4; i++){
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
} else if (head == "tablename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TableName")) variable.Value = ssTableName; else variable.Optimized = true;
} else if (head == "jsondata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".JSONData")) variable.Value = ssJSONData; else variable.Optimized = true;
} else if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserId")) variable.Value = ssUserId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdTableName)) {
return ChangedAttributes[1];
}
if (key.Equals(IdJSONData)) {
return ChangedAttributes[2];
}
if (key.Equals(IdUserId)) {
return ChangedAttributes[3];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdTableName)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdJSONData)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdUserId)) {
return OptimizedAttributes[3];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdTableName) {
return ssTableName;
}
if (key == IdJSONData) {
return ssJSONData;
}
if (key == IdUserId) {
return ssUserId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdTableName.Key.AsGuid) {
return ssTableName;
}
if (attributeKey == IdJSONData.Key.AsGuid) {
return ssJSONData;
}
if (attributeKey == IdUserId.Key.AsGuid) {
return ssUserId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(4);
OptimizedAttributes = new BitArray(4);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssTableName = (string) other.AttributeGet(IdTableName);
ChangedAttributes[1] = other.ChangedAttributeGet(IdTableName);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdTableName);
ssJSONData = (byte[]) other.AttributeGet(IdJSONData);
ChangedAttributes[2] = other.ChangedAttributeGet(IdJSONData);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdJSONData);
ssUserId = (string) other.AttributeGet(IdUserId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdUserId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdUserId);
}
} // EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord

/// <summary>
/// RecordList type <code>ColumnSettingsList</code> that represents a record list of
///  <code>ColumnSettings</code>
/// </summary>
public partial class RL_0010e646a0d3f440e6415cdc8631d1be : GenericRecordList<EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord>, IEnumerable, IEnumerator {

protected override EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord GetElementDefaultValue() {
return new EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord();
}

public T[] ToArray<T>(Func<EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0010e646a0d3f440e6415cdc8631d1be recordList, Func<EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0010e646a0d3f440e6415cdc8631d1be(EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord[] array) {
  RL_0010e646a0d3f440e6415cdc8631d1be result = new RL_0010e646a0d3f440e6415cdc8631d1be();
result.InnerFromArray(array);
    return result;
}

public static RL_0010e646a0d3f440e6415cdc8631d1be ToList<T>(T[] array, Func <T, EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord> converter) {
  RL_0010e646a0d3f440e6415cdc8631d1be result = new RL_0010e646a0d3f440e6415cdc8631d1be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0010e646a0d3f440e6415cdc8631d1be FromRestList<T>(RestList<T> restList, Func <T, EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord> converter) {
  RL_0010e646a0d3f440e6415cdc8631d1be result = new RL_0010e646a0d3f440e6415cdc8631d1be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0010e646a0d3f440e6415cdc8631d1be() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord> NewList() {
return new RL_0010e646a0d3f440e6415cdc8631d1be();
}


} // RL_0010e646a0d3f440e6415cdc8631d1be
}
