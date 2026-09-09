namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_ITEM_EM4 (+3N+C6J2MkSgFn5ziJEyXA)
///  <code>ST_5f3e5a981bd9e9a45ed03e989538932dStructure</code> that represents <code>PI_ITEM_EM4</code
/// > <p>Description: PI_ITEM_EM3</p>
/// </summary>
// Name: PI_ITEM_EM4
public partial struct ST_5f3e5a981bd9e9a45ed03e989538932dStructure : ITypedRecord<ST_5f3e5a981bd9e9a45ed03e989538932dStructure> {
internal static readonly GlobalObjectKey IdItem = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*uwMxJtlthUSZlDoE3V3+Zg");

public RL_e2d9cd11480e1409ddda73914c4a2843 ssItem;


public BitArray OptimizedAttributes;

public ST_5f3e5a981bd9e9a45ed03e989538932dStructure() {
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
public void ReadIM(ST_5f3e5a981bd9e9a45ed03e989538932dStructure r) {
this = r;
}


public static bool operator == (ST_5f3e5a981bd9e9a45ed03e989538932dStructure a, ST_5f3e5a981bd9e9a45ed03e989538932dStructure b) {
if (a.ssItem != b.ssItem) return false;
return true;
}

public static bool operator != (ST_5f3e5a981bd9e9a45ed03e989538932dStructure a, ST_5f3e5a981bd9e9a45ed03e989538932dStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_5f3e5a981bd9e9a45ed03e989538932dStructure)) return false;
return (this == (ST_5f3e5a981bd9e9a45ed03e989538932dStructure)o);
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


public ST_5f3e5a981bd9e9a45ed03e989538932dStructure Duplicate() {
ST_5f3e5a981bd9e9a45ed03e989538932dStructure t;
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
} // ST_5f3e5a981bd9e9a45ed03e989538932dStructure
/// <summary>
/// RecordList type <code>PI_ITEM_EM4List</code> that represents a record list of
///  <code>PI_ITEM_EM4</code>
/// </summary>
public partial class RL_c56ca7674ad9dba78b2278ebe632ebe7 : GenericRecordList<ST_5f3e5a981bd9e9a45ed03e989538932dStructure>, IEnumerable, IEnumerator {

protected override ST_5f3e5a981bd9e9a45ed03e989538932dStructure GetElementDefaultValue() {
return new ST_5f3e5a981bd9e9a45ed03e989538932dStructure();
}

public T[] ToArray<T>(Func<ST_5f3e5a981bd9e9a45ed03e989538932dStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c56ca7674ad9dba78b2278ebe632ebe7 recordList, Func<ST_5f3e5a981bd9e9a45ed03e989538932dStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c56ca7674ad9dba78b2278ebe632ebe7(ST_5f3e5a981bd9e9a45ed03e989538932dStructure[] array) {
  RL_c56ca7674ad9dba78b2278ebe632ebe7 result = new RL_c56ca7674ad9dba78b2278ebe632ebe7();
result.InnerFromArray(array);
    return result;
}

public static RL_c56ca7674ad9dba78b2278ebe632ebe7 ToList<T>(T[] array, Func <T, ST_5f3e5a981bd9e9a45ed03e989538932dStructure> converter) {
  RL_c56ca7674ad9dba78b2278ebe632ebe7 result = new RL_c56ca7674ad9dba78b2278ebe632ebe7();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c56ca7674ad9dba78b2278ebe632ebe7 FromRestList<T>(RestList<T> restList, Func <T, ST_5f3e5a981bd9e9a45ed03e989538932dStructure> converter) {
  RL_c56ca7674ad9dba78b2278ebe632ebe7 result = new RL_c56ca7674ad9dba78b2278ebe632ebe7();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c56ca7674ad9dba78b2278ebe632ebe7() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_5f3e5a981bd9e9a45ed03e989538932dStructure> NewList() {
return new RL_c56ca7674ad9dba78b2278ebe632ebe7();
}


} // RL_c56ca7674ad9dba78b2278ebe632ebe7
}

