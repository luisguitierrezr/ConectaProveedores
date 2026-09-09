namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (O1z+fhUHkkGDjXWSg7EFzA)
///  <code>RC_f34a41d9ffacfaba4ed60814851ecbf3</code> that represent
/// s <code>ValidationReportItemRecord</code> <p>Description: </p>
/// </summary>
// Name: ValidationReportItemRecord
public partial struct RC_f34a41d9ffacfaba4ed60814851ecbf3 : ITypedRecord<RC_f34a41d9ffacfaba4ed60814851ecbf3> {
internal static readonly GlobalObjectKey IdValidationReportItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2UFK86z_uvpO1ggUhR7L8w");

public ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure ssSTValidationReportItem;


public static implicit operator ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure( RC_f34a41d9ffacfaba4ed60814851ecbf3 r) {
return r.ssSTValidationReportItem;
}

public static implicit operator RC_f34a41d9ffacfaba4ed60814851ecbf3 (ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure r) {
RC_f34a41d9ffacfaba4ed60814851ecbf3 res = new RC_f34a41d9ffacfaba4ed60814851ecbf3 ();
res.ssSTValidationReportItem = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f34a41d9ffacfaba4ed60814851ecbf3() {
OptimizedAttributes = null;
ssSTValidationReportItem = new ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTValidationReportItem.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTValidationReportItem.Read( r, ref index);
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
public void ReadIM(RC_f34a41d9ffacfaba4ed60814851ecbf3 r) {
this = r;
}


public static bool operator == (RC_f34a41d9ffacfaba4ed60814851ecbf3 a, RC_f34a41d9ffacfaba4ed60814851ecbf3 b) {
if (a.ssSTValidationReportItem != b.ssSTValidationReportItem) return false;
return true;
}

public static bool operator != (RC_f34a41d9ffacfaba4ed60814851ecbf3 a, RC_f34a41d9ffacfaba4ed60814851ecbf3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f34a41d9ffacfaba4ed60814851ecbf3)) return false;
return (this == (RC_f34a41d9ffacfaba4ed60814851ecbf3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTValidationReportItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTValidationReportItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTValidationReportItem.InternalRecursiveSave();
}


public RC_f34a41d9ffacfaba4ed60814851ecbf3 Duplicate() {
RC_f34a41d9ffacfaba4ed60814851ecbf3 t;
t.ssSTValidationReportItem = (ST_dbb2d5cabdc5274b1c16bb4a23cc9267Structure)this.ssSTValidationReportItem.Duplicate();
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
if (head == "validationreportitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValidationReportItem")) variable.Value = ssSTValidationReportItem; else variable.Optimized = true;
variable.SetFieldName("validationreportitem");
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
if (key == IdValidationReportItem) {
return ssSTValidationReportItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValidationReportItem.Key.AsGuid) {
return ssSTValidationReportItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTValidationReportItem.FillFromOther((IRecord) other.AttributeGet(IdValidationReportItem));
}
} // RC_f34a41d9ffacfaba4ed60814851ecbf3
/// <summary>
/// RecordList type <code>ValidationReportItemRecordList</code> that represents a record list of
///  <code>ValidationReportItem</code>
/// </summary>
public partial class RL_9e0c07b54a183b2e3cca958abbc08f55 : GenericRecordList<RC_f34a41d9ffacfaba4ed60814851ecbf3>, IEnumerable, IEnumerator {

protected override RC_f34a41d9ffacfaba4ed60814851ecbf3 GetElementDefaultValue() {
return new RC_f34a41d9ffacfaba4ed60814851ecbf3();
}

public T[] ToArray<T>(Func<RC_f34a41d9ffacfaba4ed60814851ecbf3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9e0c07b54a183b2e3cca958abbc08f55 recordList, Func<RC_f34a41d9ffacfaba4ed60814851ecbf3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9e0c07b54a183b2e3cca958abbc08f55(RC_f34a41d9ffacfaba4ed60814851ecbf3[] array) {
  RL_9e0c07b54a183b2e3cca958abbc08f55 result = new RL_9e0c07b54a183b2e3cca958abbc08f55();
result.InnerFromArray(array);
    return result;
}

public static RL_9e0c07b54a183b2e3cca958abbc08f55 ToList<T>(T[] array, Func <T, RC_f34a41d9ffacfaba4ed60814851ecbf3> converter) {
  RL_9e0c07b54a183b2e3cca958abbc08f55 result = new RL_9e0c07b54a183b2e3cca958abbc08f55();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9e0c07b54a183b2e3cca958abbc08f55 FromRestList<T>(RestList<T> restList, Func <T, RC_f34a41d9ffacfaba4ed60814851ecbf3> converter) {
  RL_9e0c07b54a183b2e3cca958abbc08f55 result = new RL_9e0c07b54a183b2e3cca958abbc08f55();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9e0c07b54a183b2e3cca958abbc08f55() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f34a41d9ffacfaba4ed60814851ecbf3> NewList() {
return new RL_9e0c07b54a183b2e3cca958abbc08f55();
}


} // RL_9e0c07b54a183b2e3cca958abbc08f55
}

