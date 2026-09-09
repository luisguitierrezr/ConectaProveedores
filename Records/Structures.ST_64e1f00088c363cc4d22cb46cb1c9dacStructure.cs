namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_ITEM_SM_MO (XOPB1PnsqUC6GLTk5Dknlw)
///  <code>ST_64e1f00088c363cc4d22cb46cb1c9dacStructure</code> that represent
/// s <code>PI_ITEM_SM_MO</code> <p>Description: PI_ITEM_SM_MO</p>
/// </summary>
// Name: PI_ITEM_SM_MO
public partial struct ST_64e1f00088c363cc4d22cb46cb1c9dacStructure : ITypedRecord<ST_64e1f00088c363cc4d22cb46cb1c9dacStructure> {
internal static readonly GlobalObjectKey IdItem = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*PAU7R2Nank2ChoNRmWmUeQ");

public RL_3bcfc0997e979683ea6eaec348a88df0 ssItem;


public BitArray OptimizedAttributes;

public ST_64e1f00088c363cc4d22cb46cb1c9dacStructure() {
OptimizedAttributes = null;
ssItem = new RL_3bcfc0997e979683ea6eaec348a88df0();
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
public void ReadIM(ST_64e1f00088c363cc4d22cb46cb1c9dacStructure r) {
this = r;
}


public static bool operator == (ST_64e1f00088c363cc4d22cb46cb1c9dacStructure a, ST_64e1f00088c363cc4d22cb46cb1c9dacStructure b) {
if (a.ssItem != b.ssItem) return false;
return true;
}

public static bool operator != (ST_64e1f00088c363cc4d22cb46cb1c9dacStructure a, ST_64e1f00088c363cc4d22cb46cb1c9dacStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_64e1f00088c363cc4d22cb46cb1c9dacStructure)) return false;
return (this == (ST_64e1f00088c363cc4d22cb46cb1c9dacStructure)o);
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


public ST_64e1f00088c363cc4d22cb46cb1c9dacStructure Duplicate() {
ST_64e1f00088c363cc4d22cb46cb1c9dacStructure t;
t.ssItem = (RL_3bcfc0997e979683ea6eaec348a88df0)this.ssItem.Duplicate();
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
ssItem = new RL_3bcfc0997e979683ea6eaec348a88df0();
ssItem.FillFromOther((IOSList) other.AttributeGet(IdItem));
}
} // ST_64e1f00088c363cc4d22cb46cb1c9dacStructure
/// <summary>
/// RecordList type <code>PI_ITEM_SM_MOList</code> that represents a record list of
///  <code>PI_ITEM_SM_MO</code>
/// </summary>
public partial class RL_c2f1deecd70bc70adefb11499ff7bb2f : GenericRecordList<ST_64e1f00088c363cc4d22cb46cb1c9dacStructure>, IEnumerable, IEnumerator {

protected override ST_64e1f00088c363cc4d22cb46cb1c9dacStructure GetElementDefaultValue() {
return new ST_64e1f00088c363cc4d22cb46cb1c9dacStructure();
}

public T[] ToArray<T>(Func<ST_64e1f00088c363cc4d22cb46cb1c9dacStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c2f1deecd70bc70adefb11499ff7bb2f recordList, Func<ST_64e1f00088c363cc4d22cb46cb1c9dacStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c2f1deecd70bc70adefb11499ff7bb2f(ST_64e1f00088c363cc4d22cb46cb1c9dacStructure[] array) {
  RL_c2f1deecd70bc70adefb11499ff7bb2f result = new RL_c2f1deecd70bc70adefb11499ff7bb2f();
result.InnerFromArray(array);
    return result;
}

public static RL_c2f1deecd70bc70adefb11499ff7bb2f ToList<T>(T[] array, Func <T, ST_64e1f00088c363cc4d22cb46cb1c9dacStructure> converter) {
  RL_c2f1deecd70bc70adefb11499ff7bb2f result = new RL_c2f1deecd70bc70adefb11499ff7bb2f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c2f1deecd70bc70adefb11499ff7bb2f FromRestList<T>(RestList<T> restList, Func <T, ST_64e1f00088c363cc4d22cb46cb1c9dacStructure> converter) {
  RL_c2f1deecd70bc70adefb11499ff7bb2f result = new RL_c2f1deecd70bc70adefb11499ff7bb2f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c2f1deecd70bc70adefb11499ff7bb2f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_64e1f00088c363cc4d22cb46cb1c9dacStructure> NewList() {
return new RL_c2f1deecd70bc70adefb11499ff7bb2f();
}


} // RL_c2f1deecd70bc70adefb11499ff7bb2f
}

