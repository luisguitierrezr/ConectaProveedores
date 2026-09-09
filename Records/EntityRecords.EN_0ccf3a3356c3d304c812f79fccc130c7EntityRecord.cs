using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] ProcessType (pFeP4nUQG0Kv1A93YUZ3fQ)
///  <code>EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord</code> that represent
/// s <code>ProcessType</code> <p>Description: Process Type</p>
/// </summary>
// Name: ProcessType
public partial struct EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord : ITypedRecord<EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*pLVUwELC_E6s56qAyJrEYA");
internal static readonly GlobalObjectKey IdCode = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*QzD0IcNM8kmflgRl8xGrwA");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*WK3PrqYWB0CPcziNc9lPLw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*NEjH3OgEPUmjDWku+aVEdw");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("9NBgF2cKUEmD22aS2k06Pg*LvjdAMdS2kOzBViTUq7_wA");

private long _ssId;
public long ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(5,true);
          _ssId = value;
      }
  }
}

private string _ssCode;
public string ssCode{
  get{
      return _ssCode;
  }
  set{
      if((_ssCode!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssCode = value;
      }
  }
}

private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssLabel = value;
      }
  }
}

private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssOrder = value;
      }
  }
}

private bool _ssIs_Active;
public bool ssIs_Active{
  get{
      return _ssIs_Active;
  }
  set{
      if((_ssIs_Active!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIs_Active = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0L;
_ssCode = "";
_ssLabel = "";
_ssOrder = 0;
_ssIs_Active = false;
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
ssId = r.ReadLongInteger(index++, "ProcessType.Id", 0L);
ssCode = r.ReadText(index++, "ProcessType.Code", "");
ssLabel = r.ReadText(index++, "ProcessType.Label", "");
ssOrder = r.ReadInteger(index++, "ProcessType.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "ProcessType.Is_Active", false);
ChangedAttributes = new BitArray(5,false);
OptimizedAttributes = new BitArray(5,false);
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
public void ReadIM(EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord r) {
this = r;
}


public static bool operator == (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord a, EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssCode != b.ssCode) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
return true;
}

public static bool operator != (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord a, EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord)) return false;
return (this == (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssCode.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIs_Active.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord Duplicate() {
EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord t;
t._ssId = this._ssId;
t._ssCode = this._ssCode;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
t.ChangedAttributes = new BitArray(5);
t.OptimizedAttributes = new BitArray(5);
for(int i = 0; i < 5; i++){
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
} else if (head == "code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Code")) variable.Value = ssCode; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "is_active") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdCode)) {
return ChangedAttributes[1];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[2];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIs_Active)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdCode)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIs_Active)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
}
if (key == IdCode) {
return ssCode;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdOrder) {
return ssOrder;
}
if (key == IdIs_Active) {
return ssIs_Active;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
}
if (attributeKey == IdCode.Key.AsGuid) {
return ssCode;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdIs_Active.Key.AsGuid) {
return ssIs_Active;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (long) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssCode = (string) other.AttributeGet(IdCode);
ChangedAttributes[1] = other.ChangedAttributeGet(IdCode);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdCode);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[2] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdLabel);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[3] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdOrder);
ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIs_Active);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIs_Active);
}
} // EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord

/// <summary>
/// RecordList type <code>ProcessTypeList</code> that represents a record list of
///  <code>ProcessType</code>
/// </summary>
public partial class RL_449a21a206f144b729ef83c00a104778 : GenericRecordList<EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord>, IEnumerable, IEnumerator {

protected override EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord GetElementDefaultValue() {
return new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord();
}

public T[] ToArray<T>(Func<EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_449a21a206f144b729ef83c00a104778 recordList, Func<EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_449a21a206f144b729ef83c00a104778(EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord[] array) {
  RL_449a21a206f144b729ef83c00a104778 result = new RL_449a21a206f144b729ef83c00a104778();
result.InnerFromArray(array);
    return result;
}

public static RL_449a21a206f144b729ef83c00a104778 ToList<T>(T[] array, Func <T, EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord> converter) {
  RL_449a21a206f144b729ef83c00a104778 result = new RL_449a21a206f144b729ef83c00a104778();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_449a21a206f144b729ef83c00a104778 FromRestList<T>(RestList<T> restList, Func <T, EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord> converter) {
  RL_449a21a206f144b729ef83c00a104778 result = new RL_449a21a206f144b729ef83c00a104778();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_449a21a206f144b729ef83c00a104778() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord> NewList() {
return new RL_449a21a206f144b729ef83c00a104778();
}


} // RL_449a21a206f144b729ef83c00a104778
}
