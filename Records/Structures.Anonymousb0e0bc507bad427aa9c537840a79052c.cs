namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ULzgsK17ekKpxTeECnkFLA)
///  <code>RC_1f350886772613b21997a3d775fb549d</code> that represent
/// s <code>OrderMainSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainSupplierRecord
public partial struct RC_1f350886772613b21997a3d775fb549d : ITypedRecord<RC_1f350886772613b21997a3d775fb549d> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_1f350886772613b21997a3d775fb549d() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMain.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_1f350886772613b21997a3d775fb549d r) {
this = r;
}


public static bool operator == (RC_1f350886772613b21997a3d775fb549d a, RC_1f350886772613b21997a3d775fb549d b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_1f350886772613b21997a3d775fb549d a, RC_1f350886772613b21997a3d775fb549d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1f350886772613b21997a3d775fb549d)) return false;
return (this == (RC_1f350886772613b21997a3d775fb549d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_1f350886772613b21997a3d775fb549d Duplicate() {
RC_1f350886772613b21997a3d775fb549d t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_1f350886772613b21997a3d775fb549d
/// <summary>
/// RecordList type <code>OrderMainSupplierRecordList</code> that represents a record list of
///  <code>OrderMain, Supplier</code>
/// </summary>
public partial class RL_7954da8b922f4cb9722c2ebf9e20dca0 : GenericRecordList<RC_1f350886772613b21997a3d775fb549d>, IEnumerable, IEnumerator {

protected override RC_1f350886772613b21997a3d775fb549d GetElementDefaultValue() {
return new RC_1f350886772613b21997a3d775fb549d();
}

public T[] ToArray<T>(Func<RC_1f350886772613b21997a3d775fb549d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7954da8b922f4cb9722c2ebf9e20dca0 recordList, Func<RC_1f350886772613b21997a3d775fb549d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7954da8b922f4cb9722c2ebf9e20dca0(RC_1f350886772613b21997a3d775fb549d[] array) {
  RL_7954da8b922f4cb9722c2ebf9e20dca0 result = new RL_7954da8b922f4cb9722c2ebf9e20dca0();
result.InnerFromArray(array);
    return result;
}

public static RL_7954da8b922f4cb9722c2ebf9e20dca0 ToList<T>(T[] array, Func <T, RC_1f350886772613b21997a3d775fb549d> converter) {
  RL_7954da8b922f4cb9722c2ebf9e20dca0 result = new RL_7954da8b922f4cb9722c2ebf9e20dca0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7954da8b922f4cb9722c2ebf9e20dca0 FromRestList<T>(RestList<T> restList, Func <T, RC_1f350886772613b21997a3d775fb549d> converter) {
  RL_7954da8b922f4cb9722c2ebf9e20dca0 result = new RL_7954da8b922f4cb9722c2ebf9e20dca0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7954da8b922f4cb9722c2ebf9e20dca0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(29,false);
def[1] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1f350886772613b21997a3d775fb549d> NewList() {
return new RL_7954da8b922f4cb9722c2ebf9e20dca0();
}


} // RL_7954da8b922f4cb9722c2ebf9e20dca0
}

