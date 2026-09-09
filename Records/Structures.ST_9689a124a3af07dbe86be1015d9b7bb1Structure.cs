namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_ITEM_EM_RM (MqiqW9je7EenGkNKysczpw)
///  <code>ST_9689a124a3af07dbe86be1015d9b7bb1Structure</code> that represent
/// s <code>PI_ITEM_EM_RM</code> <p>Description: PI_ITEM_EM_RM</p>
/// </summary>
// Name: PI_ITEM_EM_RM
public partial struct ST_9689a124a3af07dbe86be1015d9b7bb1Structure : ITypedRecord<ST_9689a124a3af07dbe86be1015d9b7bb1Structure> {
internal static readonly GlobalObjectKey IdItem = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*hRRyk6HkJ0S7LqOrzpyNag");

public RL_14f7fedf363c5e2bd9b617b5d8baba14 ssItem;


public BitArray OptimizedAttributes;

public ST_9689a124a3af07dbe86be1015d9b7bb1Structure() {
OptimizedAttributes = null;
ssItem = new RL_14f7fedf363c5e2bd9b617b5d8baba14();
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
public void ReadIM(ST_9689a124a3af07dbe86be1015d9b7bb1Structure r) {
this = r;
}


public static bool operator == (ST_9689a124a3af07dbe86be1015d9b7bb1Structure a, ST_9689a124a3af07dbe86be1015d9b7bb1Structure b) {
if (a.ssItem != b.ssItem) return false;
return true;
}

public static bool operator != (ST_9689a124a3af07dbe86be1015d9b7bb1Structure a, ST_9689a124a3af07dbe86be1015d9b7bb1Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9689a124a3af07dbe86be1015d9b7bb1Structure)) return false;
return (this == (ST_9689a124a3af07dbe86be1015d9b7bb1Structure)o);
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


public ST_9689a124a3af07dbe86be1015d9b7bb1Structure Duplicate() {
ST_9689a124a3af07dbe86be1015d9b7bb1Structure t;
t.ssItem = (RL_14f7fedf363c5e2bd9b617b5d8baba14)this.ssItem.Duplicate();
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
ssItem = new RL_14f7fedf363c5e2bd9b617b5d8baba14();
ssItem.FillFromOther((IOSList) other.AttributeGet(IdItem));
}
} // ST_9689a124a3af07dbe86be1015d9b7bb1Structure
/// <summary>
/// RecordList type <code>PI_ITEM_EM_RMList</code> that represents a record list of
///  <code>PI_ITEM_EM_RM</code>
/// </summary>
public partial class RL_3dc9f4291b1ece4c6a7785794ad2ae29 : GenericRecordList<ST_9689a124a3af07dbe86be1015d9b7bb1Structure>, IEnumerable, IEnumerator {

protected override ST_9689a124a3af07dbe86be1015d9b7bb1Structure GetElementDefaultValue() {
return new ST_9689a124a3af07dbe86be1015d9b7bb1Structure();
}

public T[] ToArray<T>(Func<ST_9689a124a3af07dbe86be1015d9b7bb1Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3dc9f4291b1ece4c6a7785794ad2ae29 recordList, Func<ST_9689a124a3af07dbe86be1015d9b7bb1Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3dc9f4291b1ece4c6a7785794ad2ae29(ST_9689a124a3af07dbe86be1015d9b7bb1Structure[] array) {
  RL_3dc9f4291b1ece4c6a7785794ad2ae29 result = new RL_3dc9f4291b1ece4c6a7785794ad2ae29();
result.InnerFromArray(array);
    return result;
}

public static RL_3dc9f4291b1ece4c6a7785794ad2ae29 ToList<T>(T[] array, Func <T, ST_9689a124a3af07dbe86be1015d9b7bb1Structure> converter) {
  RL_3dc9f4291b1ece4c6a7785794ad2ae29 result = new RL_3dc9f4291b1ece4c6a7785794ad2ae29();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3dc9f4291b1ece4c6a7785794ad2ae29 FromRestList<T>(RestList<T> restList, Func <T, ST_9689a124a3af07dbe86be1015d9b7bb1Structure> converter) {
  RL_3dc9f4291b1ece4c6a7785794ad2ae29 result = new RL_3dc9f4291b1ece4c6a7785794ad2ae29();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3dc9f4291b1ece4c6a7785794ad2ae29() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9689a124a3af07dbe86be1015d9b7bb1Structure> NewList() {
return new RL_3dc9f4291b1ece4c6a7785794ad2ae29();
}


} // RL_3dc9f4291b1ece4c6a7785794ad2ae29
}

