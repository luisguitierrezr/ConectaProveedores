namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Yzy_fsZcV0iXUpS+BUTDaw)
///  <code>RC_9e12e346359269058e01a3334f3aaf87</code> that represent
/// s <code>OrderMainItemFolioItemsRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainItemFolioItemsRecord
public partial struct RC_9e12e346359269058e01a3334f3aaf87 : ITypedRecord<RC_9e12e346359269058e01a3334f3aaf87> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdFolioItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tfJh+FJZCU2OCYEVavm3qw");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems;


public BitArray OptimizedAttributes;

public RC_9e12e346359269058e01a3334f3aaf87() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(51,false);
    all[1] = new BitArray(18,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioItems.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    ssENFolioItems.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    all[1] = ssENFolioItems.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMainItem.Read( r, ref index);
ssENFolioItems.Read( r, ref index);
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
public void ReadIM(RC_9e12e346359269058e01a3334f3aaf87 r) {
this = r;
}


public static bool operator == (RC_9e12e346359269058e01a3334f3aaf87 a, RC_9e12e346359269058e01a3334f3aaf87 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENFolioItems != b.ssENFolioItems) return false;
return true;
}

public static bool operator != (RC_9e12e346359269058e01a3334f3aaf87 a, RC_9e12e346359269058e01a3334f3aaf87 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9e12e346359269058e01a3334f3aaf87)) return false;
return (this == (RC_9e12e346359269058e01a3334f3aaf87)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENFolioItems.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
ssENFolioItems.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
ssENFolioItems.InternalRecursiveSave();
}


public RC_9e12e346359269058e01a3334f3aaf87 Duplicate() {
RC_9e12e346359269058e01a3334f3aaf87 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENFolioItems = (EN_868430b5192a8eb1a739e01247fc2704EntityRecord)this.ssENFolioItems.Duplicate();
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
if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
} else if (head == "folioitems") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioItems")) variable.Value = ssENFolioItems; else variable.Optimized = true;
variable.SetFieldName("folioitems");
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
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
if (key == IdFolioItems) {
return ssENFolioItems;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
if (attributeKey == IdFolioItems.Key.AsGuid) {
return ssENFolioItems;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENFolioItems.FillFromOther((IRecord) other.AttributeGet(IdFolioItems));
}
} // RC_9e12e346359269058e01a3334f3aaf87
/// <summary>
/// RecordList type <code>OrderMainItemFolioItemsRecordList</code> that represents a record list of
///  <code>OrderMainItem, FolioItems</code>
/// </summary>
public partial class RL_c1ecbb923fb25bd526ed138d8050d95e : GenericRecordList<RC_9e12e346359269058e01a3334f3aaf87>, IEnumerable, IEnumerator {

protected override RC_9e12e346359269058e01a3334f3aaf87 GetElementDefaultValue() {
return new RC_9e12e346359269058e01a3334f3aaf87();
}

public T[] ToArray<T>(Func<RC_9e12e346359269058e01a3334f3aaf87, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c1ecbb923fb25bd526ed138d8050d95e recordList, Func<RC_9e12e346359269058e01a3334f3aaf87, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c1ecbb923fb25bd526ed138d8050d95e(RC_9e12e346359269058e01a3334f3aaf87[] array) {
  RL_c1ecbb923fb25bd526ed138d8050d95e result = new RL_c1ecbb923fb25bd526ed138d8050d95e();
result.InnerFromArray(array);
    return result;
}

public static RL_c1ecbb923fb25bd526ed138d8050d95e ToList<T>(T[] array, Func <T, RC_9e12e346359269058e01a3334f3aaf87> converter) {
  RL_c1ecbb923fb25bd526ed138d8050d95e result = new RL_c1ecbb923fb25bd526ed138d8050d95e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c1ecbb923fb25bd526ed138d8050d95e FromRestList<T>(RestList<T> restList, Func <T, RC_9e12e346359269058e01a3334f3aaf87> converter) {
  RL_c1ecbb923fb25bd526ed138d8050d95e result = new RL_c1ecbb923fb25bd526ed138d8050d95e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c1ecbb923fb25bd526ed138d8050d95e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(51,false);
def[1] = new BitArray(18,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9e12e346359269058e01a3334f3aaf87> NewList() {
return new RL_c1ecbb923fb25bd526ed138d8050d95e();
}


} // RL_c1ecbb923fb25bd526ed138d8050d95e
}

