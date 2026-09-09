namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Z1mKTVzkUEuhOUaZuz8erg)
///  <code>RC_d69ddf81a42e386a5136129388ff031f</code> that represent
/// s <code>UserRequisitionSupplierUserSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: UserRequisitionSupplierUserSupplierRecord
public partial struct RC_d69ddf81a42e386a5136129388ff031f : ITypedRecord<RC_d69ddf81a42e386a5136129388ff031f> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdSupplierUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7OnmMx8g4GXre9XSUReN7w");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public ENUserEntityRecord ssENUser;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_360367a38fba8439556dd1e5826e0428EntityRecord ssENSupplierUser;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_d69ddf81a42e386a5136129388ff031f() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENSupplierUser = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(15,false);
    all[3] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSupplierUser.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENSupplierUser.OptimizedAttributes = value[2];
    ssENSupplier.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENSupplierUser.OptimizedAttributes;
    all[3] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_d69ddf81a42e386a5136129388ff031f r) {
this = r;
}


public static bool operator == (RC_d69ddf81a42e386a5136129388ff031f a, RC_d69ddf81a42e386a5136129388ff031f b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENSupplierUser != b.ssENSupplierUser) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_d69ddf81a42e386a5136129388ff031f a, RC_d69ddf81a42e386a5136129388ff031f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d69ddf81a42e386a5136129388ff031f)) return false;
return (this == (RC_d69ddf81a42e386a5136129388ff031f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENSupplierUser.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENSupplierUser.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENSupplierUser.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_d69ddf81a42e386a5136129388ff031f Duplicate() {
RC_d69ddf81a42e386a5136129388ff031f t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "supplieruser") {
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdSupplierUser) {
return ssENSupplierUser;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
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
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENSupplierUser.FillFromOther((IRecord) other.AttributeGet(IdSupplierUser));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_d69ddf81a42e386a5136129388ff031f
/// <summary>
/// RecordList type <code>UserRequisitionSupplierUserSupplierRecordList</code> that represents a record
///  list of <code>User, Requisition, SupplierUser, Supplier</code>
/// </summary>
public partial class RL_47a3693bfacffecca219041b04d0ade1 : GenericRecordList<RC_d69ddf81a42e386a5136129388ff031f>, IEnumerable, IEnumerator {

protected override RC_d69ddf81a42e386a5136129388ff031f GetElementDefaultValue() {
return new RC_d69ddf81a42e386a5136129388ff031f();
}

public T[] ToArray<T>(Func<RC_d69ddf81a42e386a5136129388ff031f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_47a3693bfacffecca219041b04d0ade1 recordList, Func<RC_d69ddf81a42e386a5136129388ff031f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_47a3693bfacffecca219041b04d0ade1(RC_d69ddf81a42e386a5136129388ff031f[] array) {
  RL_47a3693bfacffecca219041b04d0ade1 result = new RL_47a3693bfacffecca219041b04d0ade1();
result.InnerFromArray(array);
    return result;
}

public static RL_47a3693bfacffecca219041b04d0ade1 ToList<T>(T[] array, Func <T, RC_d69ddf81a42e386a5136129388ff031f> converter) {
  RL_47a3693bfacffecca219041b04d0ade1 result = new RL_47a3693bfacffecca219041b04d0ade1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_47a3693bfacffecca219041b04d0ade1 FromRestList<T>(RestList<T> restList, Func <T, RC_d69ddf81a42e386a5136129388ff031f> converter) {
  RL_47a3693bfacffecca219041b04d0ade1 result = new RL_47a3693bfacffecca219041b04d0ade1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_47a3693bfacffecca219041b04d0ade1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(15,false);
def[3] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d69ddf81a42e386a5136129388ff031f> NewList() {
return new RL_47a3693bfacffecca219041b04d0ade1();
}


} // RL_47a3693bfacffecca219041b04d0ade1
}

