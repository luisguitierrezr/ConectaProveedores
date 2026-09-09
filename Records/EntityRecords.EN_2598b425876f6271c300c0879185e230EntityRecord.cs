using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] CustomSettings (N71x7DJaX0uROBiWhn69fA)
///  <code>EN_2598b425876f6271c300c0879185e230EntityRecord</code> that represent
/// s <code>CustomSettings</code> <p>Description: </p>
/// </summary>
// Name: CustomSettings
public partial struct EN_2598b425876f6271c300c0879185e230EntityRecord : ITypedRecord<EN_2598b425876f6271c300c0879185e230EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*zFIKIOqo_kunp+rp521kXQ");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*n58PYcOxik6EyhjCYCSU9g");
internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*55FKj0UepUi4UENOP3pTqg");
internal static readonly GlobalObjectKey IdCustomSettingTypeId = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*+Hhvk6YCZkmpAVrkDChO1Q");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*o0vH2DkvG06yxnRIUZt9PA");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("z+Hr3img9k6c__DgH+2OBw*V+vNxzW6NkOAca_UFxxbkQ");

private int _ssId;
public int ssId{
  get{
      return _ssId;
  }
  set{
      if((_ssId!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(6,true);
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

private string _ssDescription;
public string ssDescription{
  get{
      return _ssDescription;
  }
  set{
      if((_ssDescription!=value) || OptimizedAttributes[2]){
          ChangedAttributes[2] = true;
          _ssDescription = value;
      }
  }
}

private int _ssCustomSettingTypeId;
public int ssCustomSettingTypeId{
  get{
      return _ssCustomSettingTypeId;
  }
  set{
      if((_ssCustomSettingTypeId!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssCustomSettingTypeId = value;
      }
  }
}

private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
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
      if((_ssIs_Active!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIs_Active = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_2598b425876f6271c300c0879185e230EntityRecord() {
ChangedAttributes = new BitArray(6,true);
OptimizedAttributes = new BitArray(6,false);
_ssId = 0;
_ssLabel = "";
_ssDescription = "";
_ssCustomSettingTypeId = 0;
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
ssId = r.ReadInteger(index++, "CustomSettings.Id", 0);
ssLabel = r.ReadText(index++, "CustomSettings.Label", "");
ssDescription = r.ReadText(index++, "CustomSettings.Description", "");
ssCustomSettingTypeId = r.ReadEntityReference(index++, "CustomSettings.CustomSettingTypeId", 0);
ssOrder = r.ReadInteger(index++, "CustomSettings.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "CustomSettings.Is_Active", false);
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
public void ReadIM(EN_2598b425876f6271c300c0879185e230EntityRecord r) {
this = r;
}


public static bool operator == (EN_2598b425876f6271c300c0879185e230EntityRecord a, EN_2598b425876f6271c300c0879185e230EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssDescription != b.ssDescription) return false;
if (a.ssCustomSettingTypeId != b.ssCustomSettingTypeId) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
return true;
}

public static bool operator != (EN_2598b425876f6271c300c0879185e230EntityRecord a, EN_2598b425876f6271c300c0879185e230EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_2598b425876f6271c300c0879185e230EntityRecord)) return false;
return (this == (EN_2598b425876f6271c300c0879185e230EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssDescription.GetHashCode()
 ^ ssCustomSettingTypeId.GetHashCode()
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


public EN_2598b425876f6271c300c0879185e230EntityRecord Duplicate() {
EN_2598b425876f6271c300c0879185e230EntityRecord t;
t._ssId = this._ssId;
t._ssLabel = this._ssLabel;
t._ssDescription = this._ssDescription;
t._ssCustomSettingTypeId = this._ssCustomSettingTypeId;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
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
if (head == "id") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Id")) variable.Value = ssId; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "description") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
} else if (head == "customsettingtypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CustomSettingTypeId")) variable.Value = ssCustomSettingTypeId; else variable.Optimized = true;
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
if (key.Equals(IdLabel)) {
return ChangedAttributes[1];
}
if (key.Equals(IdDescription)) {
return ChangedAttributes[2];
}
if (key.Equals(IdCustomSettingTypeId)) {
return ChangedAttributes[3];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIs_Active)) {
return ChangedAttributes[5];
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
if (key.Equals(IdDescription)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdCustomSettingTypeId)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIs_Active)) {
return OptimizedAttributes[5];
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
if (key == IdDescription) {
return ssDescription;
}
if (key == IdCustomSettingTypeId) {
return ssCustomSettingTypeId;
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
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdDescription.Key.AsGuid) {
return ssDescription;
}
if (attributeKey == IdCustomSettingTypeId.Key.AsGuid) {
return ssCustomSettingTypeId;
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
ChangedAttributes = new BitArray(6);
OptimizedAttributes = new BitArray(6);
if (other == null) return;
ssId = (int) other.AttributeGet(IdId);
ChangedAttributes[0] = other.ChangedAttributeGet(IdId);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdId);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
ssDescription = (string) other.AttributeGet(IdDescription);
ChangedAttributes[2] = other.ChangedAttributeGet(IdDescription);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdDescription);
ssCustomSettingTypeId = (int) other.AttributeGet(IdCustomSettingTypeId);
ChangedAttributes[3] = other.ChangedAttributeGet(IdCustomSettingTypeId);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdCustomSettingTypeId);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[4] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdOrder);
ssIs_Active = (bool) other.AttributeGet(IdIs_Active);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIs_Active);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIs_Active);
}
} // EN_2598b425876f6271c300c0879185e230EntityRecord

/// <summary>
/// RecordList type <code>CustomSettingsList</code> that represents a record list of
///  <code>CustomSettings</code>
/// </summary>
public partial class RL_78c2eb049f952ce8323290182bf65532 : GenericRecordList<EN_2598b425876f6271c300c0879185e230EntityRecord>, IEnumerable, IEnumerator {

protected override EN_2598b425876f6271c300c0879185e230EntityRecord GetElementDefaultValue() {
return new EN_2598b425876f6271c300c0879185e230EntityRecord();
}

public T[] ToArray<T>(Func<EN_2598b425876f6271c300c0879185e230EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_78c2eb049f952ce8323290182bf65532 recordList, Func<EN_2598b425876f6271c300c0879185e230EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_78c2eb049f952ce8323290182bf65532(EN_2598b425876f6271c300c0879185e230EntityRecord[] array) {
  RL_78c2eb049f952ce8323290182bf65532 result = new RL_78c2eb049f952ce8323290182bf65532();
result.InnerFromArray(array);
    return result;
}

public static RL_78c2eb049f952ce8323290182bf65532 ToList<T>(T[] array, Func <T, EN_2598b425876f6271c300c0879185e230EntityRecord> converter) {
  RL_78c2eb049f952ce8323290182bf65532 result = new RL_78c2eb049f952ce8323290182bf65532();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_78c2eb049f952ce8323290182bf65532 FromRestList<T>(RestList<T> restList, Func <T, EN_2598b425876f6271c300c0879185e230EntityRecord> converter) {
  RL_78c2eb049f952ce8323290182bf65532 result = new RL_78c2eb049f952ce8323290182bf65532();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_78c2eb049f952ce8323290182bf65532() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_2598b425876f6271c300c0879185e230EntityRecord> NewList() {
return new RL_78c2eb049f952ce8323290182bf65532();
}


} // RL_78c2eb049f952ce8323290182bf65532
}
