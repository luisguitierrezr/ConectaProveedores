using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] AccountingDataType (w3sXvedo1Ei0O76ENwyIJw)
///  <code>EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord</code> that represent
/// s <code>AccountingDataType</code> <p>Description: Accounting Data Types.</p>
/// </summary>
// Name: AccountingDataType
public partial struct EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord : ITypedRecord<EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*0vG++BehOkWl3Xg69lvI_w");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Oi1pwsOYQUGdDZxTZYRT9w");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*vrqsTwA2HEKMlgFzGCvZWg");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*Ks8Ed2v9NkGYEGFaTW_y+A");
internal static readonly GlobalObjectKey IdIsEstim_Equal_Agreed = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*NtpxOfiTk0KzLnio0rB+MQ");

private int _ssId;
public int ssId{
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

private string _ssLabel;
public string ssLabel{
  get{
      return _ssLabel;
  }
  set{
      if((_ssLabel!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
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
      if((_ssOrder!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
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
      if((_ssIs_Active!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssIs_Active = value;
      }
  }
}

private bool _ssIsEstim_Equal_Agreed;
public bool ssIsEstim_Equal_Agreed{
  get{
      return _ssIsEstim_Equal_Agreed;
  }
  set{
      if((_ssIsEstim_Equal_Agreed!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssIsEstim_Equal_Agreed = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0;
_ssLabel = "";
_ssOrder = 0;
_ssIs_Active = false;
_ssIsEstim_Equal_Agreed = false;
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
ssId = r.ReadInteger(index++, "AccountingDataType.Id", 0);
ssLabel = r.ReadText(index++, "AccountingDataType.Label", "");
ssOrder = r.ReadInteger(index++, "AccountingDataType.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "AccountingDataType.Is_Active", false);
ssIsEstim_Equal_Agreed = r.ReadBoolean(index++, "AccountingDataType.IsEstim_Equal_Agreed", false);
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
public void ReadIM(EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord r) {
this = r;
}


public static bool operator == (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord a, EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
if (a.ssIsEstim_Equal_Agreed != b.ssIsEstim_Equal_Agreed) return false;
return true;
}

public static bool operator != (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord a, EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord)) return false;
return (this == (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIs_Active.GetHashCode()
 ^ ssIsEstim_Equal_Agreed.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord Duplicate() {
EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord t;
t._ssId = this._ssId;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
t._ssIsEstim_Equal_Agreed = this._ssIsEstim_Equal_Agreed;
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
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "is_active") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Is_Active")) variable.Value = ssIs_Active; else variable.Optimized = true;
} else if (head == "isestim_equal_agreed") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsEstim_Equal_Agreed")) variable.Value = ssIsEstim_Equal_Agreed; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return ChangedAttributes[0];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[1];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[2];
}
if (key.Equals(IdIs_Active)) {
return ChangedAttributes[3];
}
if (key.Equals(IdIsEstim_Equal_Agreed)) {
return ChangedAttributes[4];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdId)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdIs_Active)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdIsEstim_Equal_Agreed)) {
return OptimizedAttributes[4];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdId) {
return ssId;
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
if (key == IdIsEstim_Equal_Agreed) {
return ssIsEstim_Equal_Agreed;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdId.Key.AsGuid) {
return ssId;
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
if (attributeKey == IdIsEstim_Equal_Agreed.Key.AsGuid) {
return ssIsEstim_Equal_Agreed;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(5);
OptimizedAttributes = new BitArray(5);
if (other == null) return;
ssId = (int) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
ChangedAttributes[3] = other.ChangedAttributeGet(IdIs_Active);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdIs_Active);
ssIsEstim_Equal_Agreed = (bool) other.AttributeGet(IdIsEstim_Equal_Agreed);
ChangedAttributes[4] = other.ChangedAttributeGet(IdIsEstim_Equal_Agreed);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdIsEstim_Equal_Agreed);
}
} // EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord

/// <summary>
/// RecordList type <code>AccountingDataTypeList</code> that represents a record list of
///  <code>AccountingDataType</code>
/// </summary>
public partial class RL_f7c870ac5c2366529ebf75bf3d9a24ce : GenericRecordList<EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord>, IEnumerable, IEnumerator {

protected override EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord GetElementDefaultValue() {
return new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
}

public T[] ToArray<T>(Func<EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f7c870ac5c2366529ebf75bf3d9a24ce recordList, Func<EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f7c870ac5c2366529ebf75bf3d9a24ce(EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord[] array) {
  RL_f7c870ac5c2366529ebf75bf3d9a24ce result = new RL_f7c870ac5c2366529ebf75bf3d9a24ce();
result.InnerFromArray(array);
    return result;
}

public static RL_f7c870ac5c2366529ebf75bf3d9a24ce ToList<T>(T[] array, Func <T, EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord> converter) {
  RL_f7c870ac5c2366529ebf75bf3d9a24ce result = new RL_f7c870ac5c2366529ebf75bf3d9a24ce();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f7c870ac5c2366529ebf75bf3d9a24ce FromRestList<T>(RestList<T> restList, Func <T, EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord> converter) {
  RL_f7c870ac5c2366529ebf75bf3d9a24ce result = new RL_f7c870ac5c2366529ebf75bf3d9a24ce();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f7c870ac5c2366529ebf75bf3d9a24ce() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord> NewList() {
return new RL_f7c870ac5c2366529ebf75bf3d9a24ce();
}


} // RL_f7c870ac5c2366529ebf75bf3d9a24ce
}
