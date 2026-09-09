namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GYXY1yD5Sk6HSnmbkux3Nw)
///  <code>RC_ba5d2807543ac9c0e233d12b8827d820</code> that represent
/// s <code>UserOrderMainUserExtensionSupplierUserSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: UserOrderMainUserExtensionSupplierUserSupplierRecord
public partial struct RC_ba5d2807543ac9c0e233d12b8827d820 : ITypedRecord<RC_ba5d2807543ac9c0e233d12b8827d820> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdSupplierUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7OnmMx8g4GXre9XSUReN7w");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public ENUserEntityRecord ssENUser;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_360367a38fba8439556dd1e5826e0428EntityRecord ssENSupplierUser;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_ba5d2807543ac9c0e233d12b8827d820() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENSupplierUser = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(3,false);
    all[3] = new BitArray(15,false);
    all[4] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENSupplierUser.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENUserExtension.OptimizedAttributes = value[2];
    ssENSupplierUser.OptimizedAttributes = value[3];
    ssENSupplier.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENUserExtension.OptimizedAttributes;
    all[3] = ssENSupplierUser.OptimizedAttributes;
    all[4] = ssENSupplier.OptimizedAttributes;
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
ssENOrderMain.Read( r, ref index);
ssENUserExtension.Read( r, ref index);
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
public void ReadIM(RC_ba5d2807543ac9c0e233d12b8827d820 r) {
this = r;
}


public static bool operator == (RC_ba5d2807543ac9c0e233d12b8827d820 a, RC_ba5d2807543ac9c0e233d12b8827d820 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENSupplierUser != b.ssENSupplierUser) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_ba5d2807543ac9c0e233d12b8827d820 a, RC_ba5d2807543ac9c0e233d12b8827d820 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ba5d2807543ac9c0e233d12b8827d820)) return false;
return (this == (RC_ba5d2807543ac9c0e233d12b8827d820)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENSupplierUser.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENUserExtension.RecursiveReset();
ssENSupplierUser.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENSupplierUser.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_ba5d2807543ac9c0e233d12b8827d820 Duplicate() {
RC_ba5d2807543ac9c0e233d12b8827d820 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
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
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "userextension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserExtension")) variable.Value = ssENUserExtension; else variable.Optimized = true;
variable.SetFieldName("userextension");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdUserExtension) {
return ssENUserExtension;
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
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdUserExtension.Key.AsGuid) {
return ssENUserExtension;
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
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENSupplierUser.FillFromOther((IRecord) other.AttributeGet(IdSupplierUser));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_ba5d2807543ac9c0e233d12b8827d820
/// <summary>
/// RecordList type <code>UserOrderMainUserExtensionSupplierUserSupplierRecordList</code> that
///  represents a record list of <code>User, OrderMain, UserExtension, SupplierUser, Supplier</code>
/// </summary>
public partial class RL_1ff55f484c8c1943311ff58a000d50d1 : GenericRecordList<RC_ba5d2807543ac9c0e233d12b8827d820>, IEnumerable, IEnumerator {

protected override RC_ba5d2807543ac9c0e233d12b8827d820 GetElementDefaultValue() {
return new RC_ba5d2807543ac9c0e233d12b8827d820();
}

public T[] ToArray<T>(Func<RC_ba5d2807543ac9c0e233d12b8827d820, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1ff55f484c8c1943311ff58a000d50d1 recordList, Func<RC_ba5d2807543ac9c0e233d12b8827d820, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1ff55f484c8c1943311ff58a000d50d1(RC_ba5d2807543ac9c0e233d12b8827d820[] array) {
  RL_1ff55f484c8c1943311ff58a000d50d1 result = new RL_1ff55f484c8c1943311ff58a000d50d1();
result.InnerFromArray(array);
    return result;
}

public static RL_1ff55f484c8c1943311ff58a000d50d1 ToList<T>(T[] array, Func <T, RC_ba5d2807543ac9c0e233d12b8827d820> converter) {
  RL_1ff55f484c8c1943311ff58a000d50d1 result = new RL_1ff55f484c8c1943311ff58a000d50d1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1ff55f484c8c1943311ff58a000d50d1 FromRestList<T>(RestList<T> restList, Func <T, RC_ba5d2807543ac9c0e233d12b8827d820> converter) {
  RL_1ff55f484c8c1943311ff58a000d50d1 result = new RL_1ff55f484c8c1943311ff58a000d50d1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1ff55f484c8c1943311ff58a000d50d1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(3,false);
def[3] = new BitArray(15,false);
def[4] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ba5d2807543ac9c0e233d12b8827d820> NewList() {
return new RL_1ff55f484c8c1943311ff58a000d50d1();
}


} // RL_1ff55f484c8c1943311ff58a000d50d1
}

