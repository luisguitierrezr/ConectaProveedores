namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] PI_ITEM_EM_CECO (3nbo0M5lcUeMGKt8QWBW2g)
///  <code>ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure</code> that represent
/// s <code>PI_ITEM_EM_CECO</code> <p>Description: PI_ITEM_EM_CECO</p>
/// </summary>
// Name: PI_ITEM_EM_CECO
public partial struct ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure : ITypedRecord<ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure> {
internal static readonly GlobalObjectKey IdItem = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*58xMacZbg0aa_6CHHrAM7w");

public RL_e2d9cd11480e1409ddda73914c4a2843 ssItem;


public BitArray OptimizedAttributes;

public ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure() {
OptimizedAttributes = null;
ssItem = new RL_e2d9cd11480e1409ddda73914c4a2843();
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
public void ReadIM(ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure r) {
this = r;
}


public static bool operator == (ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure a, ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure b) {
if (a.ssItem != b.ssItem) return false;
return true;
}

public static bool operator != (ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure a, ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure)) return false;
return (this == (ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssItem.InternalRecursiveSave();
}


public ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure Duplicate() {
ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure t;
t.ssItem = (RL_e2d9cd11480e1409ddda73914c4a2843)this.ssItem.Duplicate();
t.OptimizedAttributes = null;
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
if (head == "item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Item")) variable.Value = ssItem; else variable.Optimized = true;
variable.SetFieldName("item");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdItem) {
return ssItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItem.Key.AsGuid) {
return ssItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssItem = new RL_e2d9cd11480e1409ddda73914c4a2843();
ssItem.FillFromOther((IOSList) other.AttributeGet(IdItem));
}
} // ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure
/// <summary>
/// RecordList type <code>PI_ITEM_EM_CECOList</code> that represents a record list of
///  <code>PI_ITEM_EM_CECO</code>
/// </summary>
public partial class RL_b9571edb95c5ab7c86c19d1f1271a2bc : GenericRecordList<ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure>, IEnumerable, IEnumerator {

protected override ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure GetElementDefaultValue() {
return new ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure();
}

public T[] ToArray<T>(Func<ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b9571edb95c5ab7c86c19d1f1271a2bc recordList, Func<ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b9571edb95c5ab7c86c19d1f1271a2bc(ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure[] array) {
  RL_b9571edb95c5ab7c86c19d1f1271a2bc result = new RL_b9571edb95c5ab7c86c19d1f1271a2bc();
result.InnerFromArray(array);
    return result;
}

public static RL_b9571edb95c5ab7c86c19d1f1271a2bc ToList<T>(T[] array, Func <T, ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure> converter) {
  RL_b9571edb95c5ab7c86c19d1f1271a2bc result = new RL_b9571edb95c5ab7c86c19d1f1271a2bc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b9571edb95c5ab7c86c19d1f1271a2bc FromRestList<T>(RestList<T> restList, Func <T, ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure> converter) {
  RL_b9571edb95c5ab7c86c19d1f1271a2bc result = new RL_b9571edb95c5ab7c86c19d1f1271a2bc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b9571edb95c5ab7c86c19d1f1271a2bc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure> NewList() {
return new RL_b9571edb95c5ab7c86c19d1f1271a2bc();
}


} // RL_b9571edb95c5ab7c86c19d1f1271a2bc
}

