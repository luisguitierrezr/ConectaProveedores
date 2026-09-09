namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (5OeHYGzN0EOxl5Qd_R5V5Q)
///  <code>RC_ef010366b3d2f0bfd976457513e62527</code> that represent
/// s <code>OrderMainItemTotalSAPRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainItemTotalSAPRecord
public partial struct RC_ef010366b3d2f0bfd976457513e62527 : ITypedRecord<RC_ef010366b3d2f0bfd976457513e62527> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdTotalSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7FKLfEOOxxXk4FlvRKps8g");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public decimal ssTotalSAP;


public BitArray OptimizedAttributes;

public RC_ef010366b3d2f0bfd976457513e62527() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssTotalSAP = 0.0M;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(51,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
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
ssTotalSAP = r.ReadDecimal(index++, "OrderMainItemTotalSAPRecord.TotalSAP", 0.0M);
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
public void ReadIM(RC_ef010366b3d2f0bfd976457513e62527 r) {
this = r;
}


public static bool operator == (RC_ef010366b3d2f0bfd976457513e62527 a, RC_ef010366b3d2f0bfd976457513e62527 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssTotalSAP != b.ssTotalSAP) return false;
return true;
}

public static bool operator != (RC_ef010366b3d2f0bfd976457513e62527 a, RC_ef010366b3d2f0bfd976457513e62527 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ef010366b3d2f0bfd976457513e62527)) return false;
return (this == (RC_ef010366b3d2f0bfd976457513e62527)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssTotalSAP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
}


public RC_ef010366b3d2f0bfd976457513e62527 Duplicate() {
RC_ef010366b3d2f0bfd976457513e62527 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssTotalSAP = this.ssTotalSAP;
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
} else if (head == "totalsap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalSAP")) variable.Value = ssTotalSAP; else variable.Optimized = true;
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
if (key == IdTotalSAP) {
return ssTotalSAP;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
if (attributeKey == IdTotalSAP.Key.AsGuid) {
return ssTotalSAP;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssTotalSAP = (decimal) other.AttributeGet(IdTotalSAP);
}
} // RC_ef010366b3d2f0bfd976457513e62527
/// <summary>
/// RecordList type <code>OrderMainItemTotalSAPRecordList</code> that represents a record list of
///  <code>OrderMainItem, Decimal</code>
/// </summary>
public partial class RL_da0a7215237722bf85869dceecaf1bc9 : GenericRecordList<RC_ef010366b3d2f0bfd976457513e62527>, IEnumerable, IEnumerator {

protected override RC_ef010366b3d2f0bfd976457513e62527 GetElementDefaultValue() {
return new RC_ef010366b3d2f0bfd976457513e62527();
}

public T[] ToArray<T>(Func<RC_ef010366b3d2f0bfd976457513e62527, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_da0a7215237722bf85869dceecaf1bc9 recordList, Func<RC_ef010366b3d2f0bfd976457513e62527, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_da0a7215237722bf85869dceecaf1bc9(RC_ef010366b3d2f0bfd976457513e62527[] array) {
  RL_da0a7215237722bf85869dceecaf1bc9 result = new RL_da0a7215237722bf85869dceecaf1bc9();
result.InnerFromArray(array);
    return result;
}

public static RL_da0a7215237722bf85869dceecaf1bc9 ToList<T>(T[] array, Func <T, RC_ef010366b3d2f0bfd976457513e62527> converter) {
  RL_da0a7215237722bf85869dceecaf1bc9 result = new RL_da0a7215237722bf85869dceecaf1bc9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_da0a7215237722bf85869dceecaf1bc9 FromRestList<T>(RestList<T> restList, Func <T, RC_ef010366b3d2f0bfd976457513e62527> converter) {
  RL_da0a7215237722bf85869dceecaf1bc9 result = new RL_da0a7215237722bf85869dceecaf1bc9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_da0a7215237722bf85869dceecaf1bc9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(51,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ef010366b3d2f0bfd976457513e62527> NewList() {
return new RL_da0a7215237722bf85869dceecaf1bc9();
}


} // RL_da0a7215237722bf85869dceecaf1bc9
}

