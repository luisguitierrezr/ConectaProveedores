using System.Diagnostics;
namespace ssConectaProveedores.ReferencesProxy {

/// <summary>
/// [ReferenceEntity] Color (tkImtPuLxUO5n523whgi8A)
///  <code>EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord</code> that represents <code>Color</code
/// > <p>Description: Different colors available.</p>
/// </summary>
// Name: Color
public partial struct EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord : ITypedRecord<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> {
internal static readonly GlobalObjectKey IdColor = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*EeOTApb+v0ecke2PZe8uAw");
internal static readonly GlobalObjectKey IdOrder = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*9PxLwBUs1kqV6w4p9wR_pA");

private string _ssColor;
public string ssColor{
  get{
      return _ssColor;
  }
  set{
      if((_ssColor!=value) || OptimizedAttributes[0]){
          ChangedAttributes = new BitArray(2,true);
          _ssColor = value;
      }
  }
}

private int _ssOrder;
public int ssOrder{
  get{
      return _ssOrder;
  }
  set{
      if((_ssOrder!=value) || OptimizedAttributes[1]){
          ChangedAttributes[1] = true;
          _ssOrder = value;
      }
  }
}


public BitArray ChangedAttributes;

public BitArray OptimizedAttributes;

public EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord() {
ChangedAttributes = new BitArray(2,true);
OptimizedAttributes = new BitArray(2,false);
_ssColor = "";
_ssOrder = 0;
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
ssColor = r.ReadText(index++, "Color.Color", "");
ssOrder = r.ReadInteger(index++, "Color.Order", 0);
ChangedAttributes = new BitArray(2,false);
OptimizedAttributes = new BitArray(2,false);
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
public void ReadIM(EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord r) {
this = r;
}


public static bool operator == (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord a, EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord b) {
if (a.ssColor != b.ssColor) return false;
if (a.ssOrder != b.ssOrder) return false;
return true;
}

public static bool operator != (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord a, EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord)) return false;
return (this == (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssColor.GetHashCode()
 ^ ssOrder.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord Duplicate() {
EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord t;
t._ssColor = this._ssColor;
t._ssOrder = this._ssOrder;
t.ChangedAttributes = new BitArray(2);
t.OptimizedAttributes = new BitArray(2);
for(int i = 0; i < 2; i++){
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
if (head == "color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Color")) variable.Value = ssColor; else variable.Optimized = true;
} else if (head == "order") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Order")) variable.Value = ssOrder; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdColor)) {
return ChangedAttributes[0];
}
if (key.Equals(IdOrder)) {
return ChangedAttributes[1];
}
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
if (key.Equals(IdColor)) {
return OptimizedAttributes[0];
}
if (key.Equals(IdOrder)) {
return OptimizedAttributes[1];
}
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdColor) {
return ssColor;
}
if (key == IdOrder) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdColor.Key.AsGuid) {
return ssColor;
}
if (attributeKey == IdOrder.Key.AsGuid) {
return ssOrder;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
ChangedAttributes = new BitArray(2);
OptimizedAttributes = new BitArray(2);
if (other == null) return;
ssColor = (string) other.AttributeGet(IdColor);
ChangedAttributes[0] = other.ChangedAttributeGet(IdColor);
OptimizedAttributes[0] = other.OptimizedAttributeGet(IdColor);
ssOrder = (int) other.AttributeGet(IdOrder);
ChangedAttributes[1] = other.ChangedAttributeGet(IdOrder);
OptimizedAttributes[1] = other.OptimizedAttributeGet(IdOrder);
}
} // EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord

/// <summary>
/// RecordList type <code>ColorList</code> that represents a record list of <code>Color</code>
/// </summary>
public partial class RL_d24415aae8bc2d864868eb4166823bd0 : GenericRecordList<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord>, IEnumerable, IEnumerator {

protected override EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord GetElementDefaultValue() {
return new EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord();
}

public T[] ToArray<T>(Func<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d24415aae8bc2d864868eb4166823bd0 recordList, Func<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d24415aae8bc2d864868eb4166823bd0(EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord[] array) {
  RL_d24415aae8bc2d864868eb4166823bd0 result = new RL_d24415aae8bc2d864868eb4166823bd0();
result.InnerFromArray(array);
    return result;
}

public static RL_d24415aae8bc2d864868eb4166823bd0 ToList<T>(T[] array, Func <T, EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> converter) {
  RL_d24415aae8bc2d864868eb4166823bd0 result = new RL_d24415aae8bc2d864868eb4166823bd0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d24415aae8bc2d864868eb4166823bd0 FromRestList<T>(RestList<T> restList, Func <T, EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> converter) {
  RL_d24415aae8bc2d864868eb4166823bd0 result = new RL_d24415aae8bc2d864868eb4166823bd0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d24415aae8bc2d864868eb4166823bd0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord> NewList() {
return new RL_d24415aae8bc2d864868eb4166823bd0();
}


} // RL_d24415aae8bc2d864868eb4166823bd0
}
