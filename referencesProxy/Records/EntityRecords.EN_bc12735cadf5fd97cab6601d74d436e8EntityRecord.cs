using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] MarginSize (xZPFXhnz6k+ocfogThpz8g)
///  <code>EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord</code> that represent
/// s <code>MarginSize</code> <p>Description: </p>
/// </summary>
// Name: MarginSize
public partial struct EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord : ITypedRecord<EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord> {
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*t0iv8_X7X0asPDWJVCLKnQ");
internal static readonly GlobalObjectKey IdLabel = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*R5PFwS0JDUqnHRK5+g0zDQ");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*1GLvyVlynk6Ed0vVLt+ZUA");
internal static readonly GlobalObjectKey IdMarginTop = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*If4C9fBUGEurZjbNEb3oMQ");
internal static readonly GlobalObjectKey IdMarginRight = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*zQl0x_144EWRyeheDOdaWA");
internal static readonly GlobalObjectKey IdMarginBottom = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*WTVgwJjBPECYXC_X1LJJPQ");
internal static readonly GlobalObjectKey IdMarginLeft = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*HPu2J7i3rUG+13pCsAqaYg");
internal static readonly GlobalObjectKey IdIsInternational = GlobalObjectKey.Parse("A23oW7gyRU24yLh6QX8VdA*7lcZXSQHg0auMLtqWRXqIA");

private string _ssSize;
public string ssSize{
  get{
      return _ssSize;
  }
  set{
      if((_ssSize!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(8,true);
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

private decimal _ssMarginTop;
public decimal ssMarginTop{
  get{
      return _ssMarginTop;
  }
  set{
      if((_ssMarginTop!=value) || OptimizedAttributes[3]){
          ChangedAttributes[3] = true;
          _ssMarginTop = value;
      }
  }
}

private decimal _ssMarginRight;
public decimal ssMarginRight{
  get{
      return _ssMarginRight;
  }
  set{
      if((_ssMarginRight!=value) || OptimizedAttributes[4]){
          ChangedAttributes[4] = true;
          _ssMarginRight = value;
      }
  }
}

private decimal _ssMarginBottom;
public decimal ssMarginBottom{
  get{
      return _ssMarginBottom;
  }
  set{
      if((_ssMarginBottom!=value) || OptimizedAttributes[5]){
          ChangedAttributes[5] = true;
          _ssMarginBottom = value;
      }
  }
}

private decimal _ssMarginLeft;
public decimal ssMarginLeft{
  get{
      return _ssMarginLeft;
  }
  set{
      if((_ssMarginLeft!=value) || OptimizedAttributes[6]){
          ChangedAttributes[6] = true;
          _ssMarginLeft = value;
      }
  }
}

private bool _ssIsInternational;
public bool ssIsInternational{
  get{
      return _ssIsInternational;
  }
  set{
      if((_ssIsInternational!=value) || OptimizedAttributes[7]){
          ChangedAttributes[7] = true;
          _ssIsInternational = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord() {
ChangedAttributes = new BitArray(8,true);
OptimizedAttributes = new BitArray(8,false);
_ssSize = "";
_ssLabel = "";
_ssOrder = 0;
_ssMarginTop = 0.0M;
_ssMarginRight = 0.0M;
_ssMarginBottom = 0.0M;
_ssMarginLeft = 0.0M;
_ssIsInternational = false;
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
ssSize = r.ReadText(index++, "MarginSize.Size", "");
ssLabel = r.ReadText(index++, "MarginSize.Label", "");
ssOrder = r.ReadInteger(index++, "MarginSize.Order", 0);
ssMarginTop = r.ReadDecimal(index++, "MarginSize.MarginTop", 0.0M);
ssMarginRight = r.ReadDecimal(index++, "MarginSize.MarginRight", 0.0M);
ssMarginBottom = r.ReadDecimal(index++, "MarginSize.MarginBottom", 0.0M);
ssMarginLeft = r.ReadDecimal(index++, "MarginSize.MarginLeft", 0.0M);
ssIsInternational = r.ReadBoolean(index++, "MarginSize.IsInternational", false);
ChangedAttributes = new BitArray(8,false);
OptimizedAttributes = new BitArray(8,false);
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
public void ReadIM(EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord r) {
this = r;
}


public static bool operator == (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord a, EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord b) {
if (a.ssSize != b.ssSize) return false;
if (a.ssLabel != b.ssLabel) return false;
if (a.ssOrder != b.ssOrder) return false;
if (a.ssMarginTop != b.ssMarginTop) return false;
if (a.ssMarginRight != b.ssMarginRight) return false;
if (a.ssMarginBottom != b.ssMarginBottom) return false;
if (a.ssMarginLeft != b.ssMarginLeft) return false;
if (a.ssIsInternational != b.ssIsInternational) return false;
return true;
}

public static bool operator != (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord a, EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord)) return false;
return (this == (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSize.GetHashCode()
 ^ ssLabel.GetHashCode()
 ^ ssOrder.GetHashCode()
 ^ ssMarginTop.GetHashCode()
 ^ ssMarginRight.GetHashCode()
 ^ ssMarginBottom.GetHashCode()
 ^ ssMarginLeft.GetHashCode()
 ^ ssIsInternational.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord Duplicate() {
EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord t;
t._ssSize = this._ssSize;
t._ssLabel = this._ssLabel;
t._ssOrder = this._ssOrder;
t._ssMarginTop = this._ssMarginTop;
t._ssMarginRight = this._ssMarginRight;
t._ssMarginBottom = this._ssMarginBottom;
t._ssMarginLeft = this._ssMarginLeft;
t._ssIsInternational = this._ssIsInternational;
t.ChangedAttributes = new BitArray(8);
t.OptimizedAttributes = new BitArray(8);
for(int i = 0; i < 8; i++){
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
} else if (head == "margintop") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarginTop")) variable.Value = ssMarginTop; else variable.Optimized = true;
} else if (head == "marginright") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarginRight")) variable.Value = ssMarginRight; else variable.Optimized = true;
} else if (head == "marginbottom") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarginBottom")) variable.Value = ssMarginBottom; else variable.Optimized = true;
} else if (head == "marginleft") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarginLeft")) variable.Value = ssMarginLeft; else variable.Optimized = true;
} else if (head == "isinternational") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsInternational")) variable.Value = ssIsInternational; else variable.Optimized = true;
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
if (key.Equals(IdMarginTop)) {
return ChangedAttributes[3];
}
if (key.Equals(IdMarginRight)) {
return ChangedAttributes[4];
}
if (key.Equals(IdMarginBottom)) {
return ChangedAttributes[5];
}
if (key.Equals(IdMarginLeft)) {
return ChangedAttributes[6];
}
if (key.Equals(IdIsInternational)) {
return ChangedAttributes[7];
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
if (key.Equals(IdMarginTop)) {
return OptimizedAttributes[3];
}
if (key.Equals(IdMarginRight)) {
return OptimizedAttributes[4];
}
if (key.Equals(IdMarginBottom)) {
return OptimizedAttributes[5];
}
if (key.Equals(IdMarginLeft)) {
return OptimizedAttributes[6];
}
if (key.Equals(IdIsInternational)) {
return OptimizedAttributes[7];
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
if (key == IdMarginTop) {
return ssMarginTop;
}
if (key == IdMarginRight) {
return ssMarginRight;
}
if (key == IdMarginBottom) {
return ssMarginBottom;
}
if (key == IdMarginLeft) {
return ssMarginLeft;
}
if (key == IdIsInternational) {
return ssIsInternational;
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
if (attributeKey == IdMarginTop.Key.AsGuid) {
return ssMarginTop;
}
if (attributeKey == IdMarginRight.Key.AsGuid) {
return ssMarginRight;
}
if (attributeKey == IdMarginBottom.Key.AsGuid) {
return ssMarginBottom;
}
if (attributeKey == IdMarginLeft.Key.AsGuid) {
return ssMarginLeft;
}
if (attributeKey == IdIsInternational.Key.AsGuid) {
return ssIsInternational;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(8);
OptimizedAttributes = new BitArray(8);
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
ssMarginTop = (decimal) other.AttributeGet(IdMarginTop);
ChangedAttributes[3] = other.ChangedAttributeGet(IdMarginTop);
OptimizedAttributes[3] = other.OptimizedAttributeGet(IdMarginTop);
ssMarginRight = (decimal) other.AttributeGet(IdMarginRight);
ChangedAttributes[4] = other.ChangedAttributeGet(IdMarginRight);
OptimizedAttributes[4] = other.OptimizedAttributeGet(IdMarginRight);
ssMarginBottom = (decimal) other.AttributeGet(IdMarginBottom);
ChangedAttributes[5] = other.ChangedAttributeGet(IdMarginBottom);
OptimizedAttributes[5] = other.OptimizedAttributeGet(IdMarginBottom);
ssMarginLeft = (decimal) other.AttributeGet(IdMarginLeft);
ChangedAttributes[6] = other.ChangedAttributeGet(IdMarginLeft);
OptimizedAttributes[6] = other.OptimizedAttributeGet(IdMarginLeft);
ssIsInternational = (bool) other.AttributeGet(IdIsInternational);
ChangedAttributes[7] = other.ChangedAttributeGet(IdIsInternational);
OptimizedAttributes[7] = other.OptimizedAttributeGet(IdIsInternational);
}
} // EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord

/// <summary>
/// RecordList type <code>MarginSizeList</code> that represents a record list of
///  <code>MarginSize</code>
/// </summary>
public partial class RL_5c612588f00b9adf77f88ae1896a4fb3 : GenericRecordList<EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord>, IEnumerable, IEnumerator {

protected override EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord GetElementDefaultValue() {
return new EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord();
}

public T[] ToArray<T>(Func<EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5c612588f00b9adf77f88ae1896a4fb3 recordList, Func<EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5c612588f00b9adf77f88ae1896a4fb3(EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord[] array) {
  RL_5c612588f00b9adf77f88ae1896a4fb3 result = new RL_5c612588f00b9adf77f88ae1896a4fb3();
result.InnerFromArray(array);
    return result;
}

public static RL_5c612588f00b9adf77f88ae1896a4fb3 ToList<T>(T[] array, Func <T, EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord> converter) {
  RL_5c612588f00b9adf77f88ae1896a4fb3 result = new RL_5c612588f00b9adf77f88ae1896a4fb3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5c612588f00b9adf77f88ae1896a4fb3 FromRestList<T>(RestList<T> restList, Func <T, EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord> converter) {
  RL_5c612588f00b9adf77f88ae1896a4fb3 result = new RL_5c612588f00b9adf77f88ae1896a4fb3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5c612588f00b9adf77f88ae1896a4fb3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord> NewList() {
return new RL_5c612588f00b9adf77f88ae1896a4fb3();
}


} // RL_5c612588f00b9adf77f88ae1896a4fb3
}
