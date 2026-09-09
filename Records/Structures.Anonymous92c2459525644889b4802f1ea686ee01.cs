namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (lUXCkmQliUi0gC8epobuAQ)
///  <code>RC_60b2ce7251b451294681274f8057cbd6</code> that represent
/// s <code>UserUserExtensionSupplierUserRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUserExtensionSupplierUserRecord
public partial struct RC_60b2ce7251b451294681274f8057cbd6 : ITypedRecord<RC_60b2ce7251b451294681274f8057cbd6> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdSupplierUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7OnmMx8g4GXre9XSUReN7w");

public ENUserEntityRecord ssENUser;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_360367a38fba8439556dd1e5826e0428EntityRecord ssENSupplierUser;


public BitArray OptimizedAttributes;

public RC_60b2ce7251b451294681274f8057cbd6() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENSupplierUser = new EN_360367a38fba8439556dd1e5826e0428EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(3,false);
    all[2] = new BitArray(15,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENSupplierUser.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUserExtension.OptimizedAttributes = value[1];
    ssENSupplierUser.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUserExtension.OptimizedAttributes;
    all[2] = ssENSupplierUser.OptimizedAttributes;
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
ssENUserExtension.Read( r, ref index);
ssENSupplierUser.Read( r, ref index);
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
public void ReadIM(RC_60b2ce7251b451294681274f8057cbd6 r) {
this = r;
}


public static bool operator == (RC_60b2ce7251b451294681274f8057cbd6 a, RC_60b2ce7251b451294681274f8057cbd6 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENSupplierUser != b.ssENSupplierUser) return false;
return true;
}

public static bool operator != (RC_60b2ce7251b451294681274f8057cbd6 a, RC_60b2ce7251b451294681274f8057cbd6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_60b2ce7251b451294681274f8057cbd6)) return false;
return (this == (RC_60b2ce7251b451294681274f8057cbd6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENSupplierUser.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUserExtension.RecursiveReset();
ssENSupplierUser.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENSupplierUser.InternalRecursiveSave();
}


public RC_60b2ce7251b451294681274f8057cbd6 Duplicate() {
RC_60b2ce7251b451294681274f8057cbd6 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
t.ssENSupplierUser = (EN_360367a38fba8439556dd1e5826e0428EntityRecord)this.ssENSupplierUser.Duplicate();
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
} else if (head == "userextension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserExtension")) variable.Value = ssENUserExtension; else variable.Optimized = true;
variable.SetFieldName("userextension");
} else if (head == "supplieruser") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierUser")) variable.Value = ssENSupplierUser; else variable.Optimized = true;
variable.SetFieldName("supplieruser");
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
if (key == IdUserExtension) {
return ssENUserExtension;
}
if (key == IdSupplierUser) {
return ssENSupplierUser;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUserExtension.Key.AsGuid) {
return ssENUserExtension;
}
if (attributeKey == IdSupplierUser.Key.AsGuid) {
return ssENSupplierUser;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENSupplierUser.FillFromOther((IRecord) other.AttributeGet(IdSupplierUser));
}
} // RC_60b2ce7251b451294681274f8057cbd6
/// <summary>
/// RecordList type <code>UserUserExtensionSupplierUserRecordList</code> that represents a record list
///  of <code>User, UserExtension, SupplierUser</code>
/// </summary>
public partial class RL_519cfbd5c9d3e969a6c55ad5a0702da1 : GenericRecordList<RC_60b2ce7251b451294681274f8057cbd6>, IEnumerable, IEnumerator {

protected override RC_60b2ce7251b451294681274f8057cbd6 GetElementDefaultValue() {
return new RC_60b2ce7251b451294681274f8057cbd6();
}

public T[] ToArray<T>(Func<RC_60b2ce7251b451294681274f8057cbd6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_519cfbd5c9d3e969a6c55ad5a0702da1 recordList, Func<RC_60b2ce7251b451294681274f8057cbd6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_519cfbd5c9d3e969a6c55ad5a0702da1(RC_60b2ce7251b451294681274f8057cbd6[] array) {
  RL_519cfbd5c9d3e969a6c55ad5a0702da1 result = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
result.InnerFromArray(array);
    return result;
}

public static RL_519cfbd5c9d3e969a6c55ad5a0702da1 ToList<T>(T[] array, Func <T, RC_60b2ce7251b451294681274f8057cbd6> converter) {
  RL_519cfbd5c9d3e969a6c55ad5a0702da1 result = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_519cfbd5c9d3e969a6c55ad5a0702da1 FromRestList<T>(RestList<T> restList, Func <T, RC_60b2ce7251b451294681274f8057cbd6> converter) {
  RL_519cfbd5c9d3e969a6c55ad5a0702da1 result = new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_519cfbd5c9d3e969a6c55ad5a0702da1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(3,false);
def[2] = new BitArray(15,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_60b2ce7251b451294681274f8057cbd6> NewList() {
return new RL_519cfbd5c9d3e969a6c55ad5a0702da1();
}


} // RL_519cfbd5c9d3e969a6c55ad5a0702da1
}

