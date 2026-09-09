namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lYwIrqRbCEq2dLb_KtYKDw)
///  <code>RC_82af454f3893e60efc22cc7344fd4176</code> that represent
/// s <code>OrderMainItemFolioItemsRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainItemFolioItemsRegionRecord
public partial struct RC_82af454f3893e60efc22cc7344fd4176 : ITypedRecord<RC_82af454f3893e60efc22cc7344fd4176> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdFolioItems = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tfJh+FJZCU2OCYEVavm3qw");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_868430b5192a8eb1a739e01247fc2704EntityRecord ssENFolioItems;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_82af454f3893e60efc22cc7344fd4176() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENFolioItems = new EN_868430b5192a8eb1a739e01247fc2704EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(51,false);
    all[1] = new BitArray(18,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioItems.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    ssENFolioItems.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    all[1] = ssENFolioItems.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
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
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_82af454f3893e60efc22cc7344fd4176 r) {
this = r;
}


public static bool operator == (RC_82af454f3893e60efc22cc7344fd4176 a, RC_82af454f3893e60efc22cc7344fd4176 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENFolioItems != b.ssENFolioItems) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_82af454f3893e60efc22cc7344fd4176 a, RC_82af454f3893e60efc22cc7344fd4176 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_82af454f3893e60efc22cc7344fd4176)) return false;
return (this == (RC_82af454f3893e60efc22cc7344fd4176)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENFolioItems.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
ssENFolioItems.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
ssENFolioItems.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_82af454f3893e60efc22cc7344fd4176 Duplicate() {
RC_82af454f3893e60efc22cc7344fd4176 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENFolioItems = (EN_868430b5192a8eb1a739e01247fc2704EntityRecord)this.ssENFolioItems.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdRegion) {
return ssENRegion;
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
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENFolioItems.FillFromOther((IRecord) other.AttributeGet(IdFolioItems));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_82af454f3893e60efc22cc7344fd4176
/// <summary>
/// RecordList type <code>OrderMainItemFolioItemsRegionRecordList</code> that represents a record list
///  of <code>OrderMainItem, FolioItems, Region</code>
/// </summary>
public partial class RL_af9a0ce202ec088a3c6de60c469b7bc6 : GenericRecordList<RC_82af454f3893e60efc22cc7344fd4176>, IEnumerable, IEnumerator {

protected override RC_82af454f3893e60efc22cc7344fd4176 GetElementDefaultValue() {
return new RC_82af454f3893e60efc22cc7344fd4176();
}

public T[] ToArray<T>(Func<RC_82af454f3893e60efc22cc7344fd4176, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_af9a0ce202ec088a3c6de60c469b7bc6 recordList, Func<RC_82af454f3893e60efc22cc7344fd4176, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_af9a0ce202ec088a3c6de60c469b7bc6(RC_82af454f3893e60efc22cc7344fd4176[] array) {
  RL_af9a0ce202ec088a3c6de60c469b7bc6 result = new RL_af9a0ce202ec088a3c6de60c469b7bc6();
result.InnerFromArray(array);
    return result;
}

public static RL_af9a0ce202ec088a3c6de60c469b7bc6 ToList<T>(T[] array, Func <T, RC_82af454f3893e60efc22cc7344fd4176> converter) {
  RL_af9a0ce202ec088a3c6de60c469b7bc6 result = new RL_af9a0ce202ec088a3c6de60c469b7bc6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_af9a0ce202ec088a3c6de60c469b7bc6 FromRestList<T>(RestList<T> restList, Func <T, RC_82af454f3893e60efc22cc7344fd4176> converter) {
  RL_af9a0ce202ec088a3c6de60c469b7bc6 result = new RL_af9a0ce202ec088a3c6de60c469b7bc6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_af9a0ce202ec088a3c6de60c469b7bc6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(51,false);
def[1] = new BitArray(18,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_82af454f3893e60efc22cc7344fd4176> NewList() {
return new RL_af9a0ce202ec088a3c6de60c469b7bc6();
}


} // RL_af9a0ce202ec088a3c6de60c469b7bc6
}

