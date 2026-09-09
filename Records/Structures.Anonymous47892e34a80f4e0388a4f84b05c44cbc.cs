namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (NC6JRw+oA06IpPhLBcRMvA)
///  <code>RC_7ff0d2d2388d9acf793b4f023e6f8f0f</code> that represent
/// s <code>OrderMainSupplierUserSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainSupplierUserSupplierRecord
public partial struct RC_7ff0d2d2388d9acf793b4f023e6f8f0f : ITypedRecord<RC_7ff0d2d2388d9acf793b4f023e6f8f0f> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplierUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7OnmMx8g4GXre9XSUReN7w");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_360367a38fba8439556dd1e5826e0428EntityRecord ssENSupplierUser;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_7ff0d2d2388d9acf793b4f023e6f8f0f() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplierUser = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(15,false);
    all[2] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplierUser.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENSupplierUser.OptimizedAttributes = value[1];
    ssENSupplier.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENSupplierUser.OptimizedAttributes;
    all[2] = ssENSupplier.OptimizedAttributes;
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
public void ReadIM(RC_7ff0d2d2388d9acf793b4f023e6f8f0f r) {
this = r;
}


public static bool operator == (RC_7ff0d2d2388d9acf793b4f023e6f8f0f a, RC_7ff0d2d2388d9acf793b4f023e6f8f0f b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplierUser != b.ssENSupplierUser) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_7ff0d2d2388d9acf793b4f023e6f8f0f a, RC_7ff0d2d2388d9acf793b4f023e6f8f0f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7ff0d2d2388d9acf793b4f023e6f8f0f)) return false;
return (this == (RC_7ff0d2d2388d9acf793b4f023e6f8f0f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplierUser.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
ssENSupplierUser.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENSupplierUser.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_7ff0d2d2388d9acf793b4f023e6f8f0f Duplicate() {
RC_7ff0d2d2388d9acf793b4f023e6f8f0f t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdOrderMain) {
return ssENOrderMain;
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
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
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
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplierUser.FillFromOther((IRecord) other.AttributeGet(IdSupplierUser));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_7ff0d2d2388d9acf793b4f023e6f8f0f
/// <summary>
/// RecordList type <code>OrderMainSupplierUserSupplierRecordList</code> that represents a record list
///  of <code>OrderMain, SupplierUser, Supplier</code>
/// </summary>
public partial class RL_41fd2052c0bcb4477e93a1b27c923798 : GenericRecordList<RC_7ff0d2d2388d9acf793b4f023e6f8f0f>, IEnumerable, IEnumerator {

protected override RC_7ff0d2d2388d9acf793b4f023e6f8f0f GetElementDefaultValue() {
return new RC_7ff0d2d2388d9acf793b4f023e6f8f0f();
}

public T[] ToArray<T>(Func<RC_7ff0d2d2388d9acf793b4f023e6f8f0f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_41fd2052c0bcb4477e93a1b27c923798 recordList, Func<RC_7ff0d2d2388d9acf793b4f023e6f8f0f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_41fd2052c0bcb4477e93a1b27c923798(RC_7ff0d2d2388d9acf793b4f023e6f8f0f[] array) {
  RL_41fd2052c0bcb4477e93a1b27c923798 result = new RL_41fd2052c0bcb4477e93a1b27c923798();
result.InnerFromArray(array);
    return result;
}

public static RL_41fd2052c0bcb4477e93a1b27c923798 ToList<T>(T[] array, Func <T, RC_7ff0d2d2388d9acf793b4f023e6f8f0f> converter) {
  RL_41fd2052c0bcb4477e93a1b27c923798 result = new RL_41fd2052c0bcb4477e93a1b27c923798();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_41fd2052c0bcb4477e93a1b27c923798 FromRestList<T>(RestList<T> restList, Func <T, RC_7ff0d2d2388d9acf793b4f023e6f8f0f> converter) {
  RL_41fd2052c0bcb4477e93a1b27c923798 result = new RL_41fd2052c0bcb4477e93a1b27c923798();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_41fd2052c0bcb4477e93a1b27c923798() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(29,false);
def[1] = new BitArray(15,false);
def[2] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7ff0d2d2388d9acf793b4f023e6f8f0f> NewList() {
return new RL_41fd2052c0bcb4477e93a1b27c923798();
}


} // RL_41fd2052c0bcb4477e93a1b27c923798
}

