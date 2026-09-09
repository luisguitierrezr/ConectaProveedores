using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [Entity] OrderRetentionType (UQCLGv8y306mu_WwowzOdQ)
///  <code>EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord</code> that represent
/// s <code>OrderRetentionType</code> <p>Description: Order Retention Type</p>
/// </summary>
// Name: OrderRetentionType
public partial struct EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord : ITypedRecord<EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord> {
internal static readonly GlobalObjectKey IdId = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*kbrf0hiI202Rhbsk9iUk+g");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*ao4S4ZtfWkW8c4i6gAdBYA");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*S5vGrI6N1UyGBSTFq75f2Q");
internal static readonly GlobalObjectKey IdIs_Active = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*YToEjDscxkC00804dAA_wg");
internal static readonly GlobalObjectKey IdPercentage = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*B4KtMXFp20e4QC7IRzBugg");

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

private decimal _ssPercentage;
public decimal ssPercentage{
  get{
      return _ssPercentage;
  }
  set{
      if((_ssPercentage!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssPercentage = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord() {
ChangedAttributes = new BitArray(5,true);
OptimizedAttributes = new BitArray(5,false);
_ssId = 0;
_ssLabel = "";
_ssOrder = 0;
_ssIs_Active = false;
_ssPercentage = 0.0M;
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
ssId = r.ReadInteger(index++, "OrderRetentionType.Id", 0);
ssLabel = r.ReadText(index++, "OrderRetentionType.Label", "");
ssOrder = r.ReadInteger(index++, "OrderRetentionType.Order", 0);
ssIs_Active = r.ReadBoolean(index++, "OrderRetentionType.Is_Active", false);
ssPercentage = r.ReadDecimal(index++, "OrderRetentionType.Percentage", 0.0M);
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
public void ReadIM(EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord r) {
this = r;
}


public static bool operator == (EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord a, EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord b) {
if (a.ssId != b.ssId) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssIs_Active != b.ssIs_Active) return false;
if (a.ssPercentage != b.ssPercentage) return false;
return true;
}

public static bool operator != (EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord a, EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord)) return false;
return (this == (EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssId.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssIs_Active.GetHashCode()
 ^ ssPercentage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord Duplicate() {
EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord t;
t._ssId = this._ssId;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
t._ssIs_Active = this._ssIs_Active;
t._ssPercentage = this._ssPercentage;
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
} else if (head == "percentage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Percentage")) variable.Value = ssPercentage; else variable.Optimized = true;
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
if (key.Equals(IdPercentage)) {
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
if (key.Equals(IdPercentage)) {
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
if (key == IdPercentage) {
return ssPercentage;
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
if (attributeKey == IdPercentage.Key.AsGuid) {
return ssPercentage;
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
ssPercentage = (decimal) other.AttributeGet(IdPercentage);
ChangedAttributes[4] = other.ChangedAttributeGet(IdPercentage);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdPercentage);
}
} // EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord

/// <summary>
/// RecordList type <code>OrderRetentionTypeList</code> that represents a record list of
///  <code>OrderRetentionType</code>
/// </summary>
public partial class RL_6fcf8a044025aa8382959ed25aa84cb3 : GenericRecordList<EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord>, IEnumerable, IEnumerator {

protected override EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord GetElementDefaultValue() {
return new EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord();
}

public T[] ToArray<T>(Func<EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6fcf8a044025aa8382959ed25aa84cb3 recordList, Func<EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6fcf8a044025aa8382959ed25aa84cb3(EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord[] array) {
  RL_6fcf8a044025aa8382959ed25aa84cb3 result = new RL_6fcf8a044025aa8382959ed25aa84cb3();
result.InnerFromArray(array);
    return result;
}

public static RL_6fcf8a044025aa8382959ed25aa84cb3 ToList<T>(T[] array, Func <T, EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord> converter) {
  RL_6fcf8a044025aa8382959ed25aa84cb3 result = new RL_6fcf8a044025aa8382959ed25aa84cb3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6fcf8a044025aa8382959ed25aa84cb3 FromRestList<T>(RestList<T> restList, Func <T, EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord> converter) {
  RL_6fcf8a044025aa8382959ed25aa84cb3 result = new RL_6fcf8a044025aa8382959ed25aa84cb3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6fcf8a044025aa8382959ed25aa84cb3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_4687fb2520dfeecb0ed6626cf8701229EntityRecord> NewList() {
return new RL_6fcf8a044025aa8382959ed25aa84cb3();
}


} // RL_6fcf8a044025aa8382959ed25aa84cb3
}
