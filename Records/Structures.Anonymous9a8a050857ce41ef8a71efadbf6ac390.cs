namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CAWKms5X70GKce+tv2rDkA)
///  <code>RC_187912d0df64c67be181be3d4f7af5f3</code> that represent
/// s <code>SupplierUserSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: SupplierUserSupplierRecord
public partial struct RC_187912d0df64c67be181be3d4f7af5f3 : ITypedRecord<RC_187912d0df64c67be181be3d4f7af5f3> {
internal static readonly GlobalObjectKey IdSupplierUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7OnmMx8g4GXre9XSUReN7w");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_360367a38fba8439556dd1e5826e0428EntityRecord ssENSupplierUser;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_187912d0df64c67be181be3d4f7af5f3() {
OptimizedAttributes = null;
ssENSupplierUser = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(15,false);
    all[1] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSupplierUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENSupplierUser.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENSupplierUser.OptimizedAttributes;
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
ssENSupplierUser.Read( r, ref index);
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
public void ReadIM(RC_187912d0df64c67be181be3d4f7af5f3 r) {
this = r;
}


public static bool operator == (RC_187912d0df64c67be181be3d4f7af5f3 a, RC_187912d0df64c67be181be3d4f7af5f3 b) {
if (a.ssENSupplierUser != b.ssENSupplierUser) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_187912d0df64c67be181be3d4f7af5f3 a, RC_187912d0df64c67be181be3d4f7af5f3 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_187912d0df64c67be181be3d4f7af5f3)) return false;
return (this == (RC_187912d0df64c67be181be3d4f7af5f3)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSupplierUser.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSupplierUser.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSupplierUser.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_187912d0df64c67be181be3d4f7af5f3 Duplicate() {
RC_187912d0df64c67be181be3d4f7af5f3 t;
t.ssENSupplierUser = (EN_360367a38fba8439556dd1e5826e0428EntityRecord)this.ssENSupplierUser.Duplicate();
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
if (head == "supplieruser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierUser")) variable.Value = ssENSupplierUser; else variable.Optimized = true;
variable.SetFieldName("supplieruser");
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
if (key == IdSupplierUser) {
return ssENSupplierUser;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSupplierUser.Key.AsGuid) {
return ssENSupplierUser;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSupplierUser.FillFromOther((IRecord) other.AttributeGet(IdSupplierUser));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_187912d0df64c67be181be3d4f7af5f3
/// <summary>
/// RecordList type <code>SupplierUserSupplierRecordList</code> that represents a record list of
///  <code>SupplierUser, Supplier</code>
/// </summary>
public partial class RL_5a0829a2b3c6573471cd9bfcbf323787 : GenericRecordList<RC_187912d0df64c67be181be3d4f7af5f3>, IEnumerable, IEnumerator {

protected override RC_187912d0df64c67be181be3d4f7af5f3 GetElementDefaultValue() {
return new RC_187912d0df64c67be181be3d4f7af5f3();
}

public T[] ToArray<T>(Func<RC_187912d0df64c67be181be3d4f7af5f3, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5a0829a2b3c6573471cd9bfcbf323787 recordList, Func<RC_187912d0df64c67be181be3d4f7af5f3, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5a0829a2b3c6573471cd9bfcbf323787(RC_187912d0df64c67be181be3d4f7af5f3[] array) {
  RL_5a0829a2b3c6573471cd9bfcbf323787 result = new RL_5a0829a2b3c6573471cd9bfcbf323787();
result.InnerFromArray(array);
    return result;
}

public static RL_5a0829a2b3c6573471cd9bfcbf323787 ToList<T>(T[] array, Func <T, RC_187912d0df64c67be181be3d4f7af5f3> converter) {
  RL_5a0829a2b3c6573471cd9bfcbf323787 result = new RL_5a0829a2b3c6573471cd9bfcbf323787();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5a0829a2b3c6573471cd9bfcbf323787 FromRestList<T>(RestList<T> restList, Func <T, RC_187912d0df64c67be181be3d4f7af5f3> converter) {
  RL_5a0829a2b3c6573471cd9bfcbf323787 result = new RL_5a0829a2b3c6573471cd9bfcbf323787();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5a0829a2b3c6573471cd9bfcbf323787() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(15,false);
def[1] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_187912d0df64c67be181be3d4f7af5f3> NewList() {
return new RL_5a0829a2b3c6573471cd9bfcbf323787();
}


} // RL_5a0829a2b3c6573471cd9bfcbf323787
}

