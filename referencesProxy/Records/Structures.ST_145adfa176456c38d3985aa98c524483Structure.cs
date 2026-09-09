namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] PI_ITEM_SM_RM (4uaP6heeQUu7O9mRj3uAlQ)
///  <code>ST_145adfa176456c38d3985aa98c524483Structure</code> that represent
/// s <code>PI_ITEM_SM_RM</code> <p>Description: PI_ITEM_SM_RM</p>
/// </summary>
// Name: PI_ITEM_SM_RM
public partial struct ST_145adfa176456c38d3985aa98c524483Structure : ITypedRecord<ST_145adfa176456c38d3985aa98c524483Structure> {
internal static readonly GlobalObjectKey IdItem = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*DyaQD_zZ60arxXky+ly43A");

public RL_943f32302be61b51261512f4da403b2f ssItem;


public BitArray OptimizedAttributes;

public ST_145adfa176456c38d3985aa98c524483Structure() {
OptimizedAttributes = null;
ssItem = new RL_943f32302be61b51261512f4da403b2f();
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
public void ReadIM(ST_145adfa176456c38d3985aa98c524483Structure r) {
this = r;
}


public static bool operator == (ST_145adfa176456c38d3985aa98c524483Structure a, ST_145adfa176456c38d3985aa98c524483Structure b) {
if (a.ssItem != b.ssItem) return false;
return true;
}

public static bool operator != (ST_145adfa176456c38d3985aa98c524483Structure a, ST_145adfa176456c38d3985aa98c524483Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_145adfa176456c38d3985aa98c524483Structure)) return false;
return (this == (ST_145adfa176456c38d3985aa98c524483Structure)o);
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


public ST_145adfa176456c38d3985aa98c524483Structure Duplicate() {
ST_145adfa176456c38d3985aa98c524483Structure t;
t.ssItem = (RL_943f32302be61b51261512f4da403b2f)this.ssItem.Duplicate();
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
ssItem = new RL_943f32302be61b51261512f4da403b2f();
ssItem.FillFromOther((IOSList) other.AttributeGet(IdItem));
}
} // ST_145adfa176456c38d3985aa98c524483Structure
/// <summary>
/// RecordList type <code>PI_ITEM_SM_RMList</code> that represents a record list of
///  <code>PI_ITEM_SM_RM</code>
/// </summary>
public partial class RL_cd5e78b69cedcf9c8159368848ac0c09 : GenericRecordList<ST_145adfa176456c38d3985aa98c524483Structure>, IEnumerable, IEnumerator {

protected override ST_145adfa176456c38d3985aa98c524483Structure GetElementDefaultValue() {
return new ST_145adfa176456c38d3985aa98c524483Structure();
}

public T[] ToArray<T>(Func<ST_145adfa176456c38d3985aa98c524483Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_cd5e78b69cedcf9c8159368848ac0c09 recordList, Func<ST_145adfa176456c38d3985aa98c524483Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_cd5e78b69cedcf9c8159368848ac0c09(ST_145adfa176456c38d3985aa98c524483Structure[] array) {
  RL_cd5e78b69cedcf9c8159368848ac0c09 result = new RL_cd5e78b69cedcf9c8159368848ac0c09();
result.InnerFromArray(array);
    return result;
}

public static RL_cd5e78b69cedcf9c8159368848ac0c09 ToList<T>(T[] array, Func <T, ST_145adfa176456c38d3985aa98c524483Structure> converter) {
  RL_cd5e78b69cedcf9c8159368848ac0c09 result = new RL_cd5e78b69cedcf9c8159368848ac0c09();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_cd5e78b69cedcf9c8159368848ac0c09 FromRestList<T>(RestList<T> restList, Func <T, ST_145adfa176456c38d3985aa98c524483Structure> converter) {
  RL_cd5e78b69cedcf9c8159368848ac0c09 result = new RL_cd5e78b69cedcf9c8159368848ac0c09();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_cd5e78b69cedcf9c8159368848ac0c09() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_145adfa176456c38d3985aa98c524483Structure> NewList() {
return new RL_cd5e78b69cedcf9c8159368848ac0c09();
}


} // RL_cd5e78b69cedcf9c8159368848ac0c09
}

