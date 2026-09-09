using System.Diagnostics;
namespace ssConectaProveedores {

/// <summary>
/// [ReferenceEntity] PaperSize (c8ensW9odEC7ZN4OB7WGvw)
///  <code>EN_7f47ecde673669f1866fae1765d30761EntityRecord</code> that represents <code>PaperSize</code
/// > <p>Description: </p>
/// </summary>
// Name: PaperSize
public partial struct EN_7f47ecde673669f1866fae1765d30761EntityRecord : ITypedRecord<EN_7f47ecde673669f1866fae1765d30761EntityRecord> {
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*lsS0RtYP+kCGT3xDWU7uWw");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*YLnfMakMr0mFTPQv+yhiyw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*nkEKokJlfkywtweeRxlRSw");
internal static readonly GlobalObjectKey IdWidth = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*ah5LwhznIEKY66UsiWR9MQ");
internal static readonly GlobalObjectKey IdHeight = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*99wfzZqd_Eiqs3zRvb0qLw");
internal static readonly GlobalObjectKey IdIsInternational = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*0NwbSZqJo06NG_g_s6jWuw");
internal static readonly GlobalObjectKey IdIsLandscape = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*KgcUEpdbJEGqfN__aEHAMA");

private string _ssSize;
public string ssSize{
  get{
      return _ssSize;
  }
  set{
      if((_ssSize!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(7,true);
          _ssSize = value;
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

private decimal _ssWidth;
public decimal ssWidth{
  get{
      return _ssWidth;
  }
  set{
      if((_ssWidth!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssWidth = value;
      }
  }
}

private decimal _ssHeight;
public decimal ssHeight{
  get{
      return _ssHeight;
  }
  set{
      if((_ssHeight!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssHeight = value;
      }
  }
}

private bool _ssIsInternational;
public bool ssIsInternational{
  get{
      return _ssIsInternational;
  }
  set{
      if((_ssIsInternational!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssIsInternational = value;
      }
  }
}

private bool _ssIsLandscape;
public bool ssIsLandscape{
  get{
      return _ssIsLandscape;
  }
  set{
      if((_ssIsLandscape!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssIsLandscape = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_7f47ecde673669f1866fae1765d30761EntityRecord() {
ChangedAttributes = new BitArray(7,true);
OptimizedAttributes = new BitArray(7,false);
_ssSize = "";
_ssLabel = "";
_ssOrder = 0;
_ssWidth = 0.0M;
_ssHeight = 0.0M;
_ssIsInternational = false;
_ssIsLandscape = false;
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
ssSize = r.ReadText(index++, "PaperSize.Size", "");
ssLabel = r.ReadText(index++, "PaperSize.Label", "");
ssOrder = r.ReadInteger(index++, "PaperSize.Order", 0);
ssWidth = r.ReadDecimal(index++, "PaperSize.Width", 0.0M);
ssHeight = r.ReadDecimal(index++, "PaperSize.Height", 0.0M);
ssIsInternational = r.ReadBoolean(index++, "PaperSize.IsInternational", false);
ssIsLandscape = r.ReadBoolean(index++, "PaperSize.IsLandscape", false);
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
public void ReadIM(EN_7f47ecde673669f1866fae1765d30761EntityRecord r) {
this = r;
}


public static bool operator == (EN_7f47ecde673669f1866fae1765d30761EntityRecord a, EN_7f47ecde673669f1866fae1765d30761EntityRecord b) {
if (a.ssSize != b.ssSize) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssWidth != b.ssWidth) return false;
if (a.ssHeight != b.ssHeight) return false;
if (a.ssIsInternational != b.ssIsInternational) return false;
if (a.ssIsLandscape != b.ssIsLandscape) return false;
return true;
}

public static bool operator != (EN_7f47ecde673669f1866fae1765d30761EntityRecord a, EN_7f47ecde673669f1866fae1765d30761EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_7f47ecde673669f1866fae1765d30761EntityRecord)) return false;
return (this == (EN_7f47ecde673669f1866fae1765d30761EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSize.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssWidth.GetHashCode()
 ^ ssHeight.GetHashCode()
 ^ ssIsInternational.GetHashCode()
 ^ ssIsLandscape.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_7f47ecde673669f1866fae1765d30761EntityRecord Duplicate() {
EN_7f47ecde673669f1866fae1765d30761EntityRecord t;
t._ssSize = this._ssSize;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
t._ssWidth = this._ssWidth;
t._ssHeight = this._ssHeight;
t._ssIsInternational = this._ssIsInternational;
t._ssIsLandscape = this._ssIsLandscape;
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
if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
} else if (head == "label") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Label")) variable.Value = ssLabel; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
} else if (head == "width") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Width")) variable.Value = ssWidth; else variable.Optimized = true;
} else if (head == "height") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Height")) variable.Value = ssHeight; else variable.Optimized = true;
} else if (head == "isinternational") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsInternational")) variable.Value = ssIsInternational; else variable.Optimized = true;
} else if (head == "islandscape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsLandscape")) variable.Value = ssIsLandscape; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSize)) {
return ChangedAttributes[0];
}
if (key.Equals(IdLabel)) {
return ChangedAttributes[1];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[2];
}
if (key.Equals(IdWidth)) {
return ChangedAttributes[3];
}
if (key.Equals(IdHeight)) {
return ChangedAttributes[4];
}
if (key.Equals(IdIsInternational)) {
return ChangedAttributes[5];
}
if (key.Equals(IdIsLandscape)) {
return ChangedAttributes[6];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdSize)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdLabel)) {
return OptimizedAttributes[1];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[2];
}
if (key.Equals(IdWidth)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdHeight)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdIsInternational)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdIsLandscape)) {
return OptimizedAttributes[6];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSize) {
return ssSize;
}
if (key == IdLabel) {
return ssLabel;
}
if (key == IdOrder) {
return ssOrder;
}
if (key == IdWidth) {
return ssWidth;
}
if (key == IdHeight) {
return ssHeight;
}
if (key == IdIsInternational) {
return ssIsInternational;
}
if (key == IdIsLandscape) {
return ssIsLandscape;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
if (attributeKey == IdLabel.Key.AsGuid) {
return ssLabel;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
if (attributeKey == IdWidth.Key.AsGuid) {
return ssWidth;
}
if (attributeKey == IdHeight.Key.AsGuid) {
return ssHeight;
}
if (attributeKey == IdIsInternational.Key.AsGuid) {
return ssIsInternational;
}
if (attributeKey == IdIsLandscape.Key.AsGuid) {
return ssIsLandscape;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(7);
OptimizedAttributes = new BitArray(7);
if (other == null) return;
ssSize = (string) other.AttributeGet(IdSize);
ChangedAttributes[0] = other.ChangedAttributeGet(IdSize);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdSize);
ssLabel = (string) other.AttributeGet(IdLabel);
ChangedAttributes[1] = other.ChangedAttributeGet(IdLabel);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdLabel);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[2] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[2] = other.OptimizedAttributeGet(IdOrder);
ssWidth = (decimal) other.AttributeGet(IdWidth);
ChangedAttributes[3] = other.ChangedAttributeGet(IdWidth);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdWidth);
ssHeight = (decimal) other.AttributeGet(IdHeight);
ChangedAttributes[4] = other.ChangedAttributeGet(IdHeight);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdHeight);
ssIsInternational = (bool) other.AttributeGet(IdIsInternational);
ChangedAttributes[5] = other.ChangedAttributeGet(IdIsInternational);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdIsInternational);
ssIsLandscape = (bool) other.AttributeGet(IdIsLandscape);
ChangedAttributes[6] = other.ChangedAttributeGet(IdIsLandscape);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdIsLandscape);
}
} // EN_7f47ecde673669f1866fae1765d30761EntityRecord

/// <summary>
/// RecordList type <code>PaperSizeList</code> that represents a record list of <code>PaperSize</code>
/// </summary>
public partial class RL_aabfd929f7b6d9fb213d97d49a627dbc : GenericRecordList<EN_7f47ecde673669f1866fae1765d30761EntityRecord>, IEnumerable, IEnumerator {

protected override EN_7f47ecde673669f1866fae1765d30761EntityRecord GetElementDefaultValue() {
return new EN_7f47ecde673669f1866fae1765d30761EntityRecord();
}

public T[] ToArray<T>(Func<EN_7f47ecde673669f1866fae1765d30761EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_aabfd929f7b6d9fb213d97d49a627dbc recordList, Func<EN_7f47ecde673669f1866fae1765d30761EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_aabfd929f7b6d9fb213d97d49a627dbc(EN_7f47ecde673669f1866fae1765d30761EntityRecord[] array) {
  RL_aabfd929f7b6d9fb213d97d49a627dbc result = new RL_aabfd929f7b6d9fb213d97d49a627dbc();
result.InnerFromArray(array);
    return result;
}

public static RL_aabfd929f7b6d9fb213d97d49a627dbc ToList<T>(T[] array, Func <T, EN_7f47ecde673669f1866fae1765d30761EntityRecord> converter) {
  RL_aabfd929f7b6d9fb213d97d49a627dbc result = new RL_aabfd929f7b6d9fb213d97d49a627dbc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_aabfd929f7b6d9fb213d97d49a627dbc FromRestList<T>(RestList<T> restList, Func <T, EN_7f47ecde673669f1866fae1765d30761EntityRecord> converter) {
  RL_aabfd929f7b6d9fb213d97d49a627dbc result = new RL_aabfd929f7b6d9fb213d97d49a627dbc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_aabfd929f7b6d9fb213d97d49a627dbc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_7f47ecde673669f1866fae1765d30761EntityRecord> NewList() {
return new RL_aabfd929f7b6d9fb213d97d49a627dbc();
}


} // RL_aabfd929f7b6d9fb213d97d49a627dbc
}
