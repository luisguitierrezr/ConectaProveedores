namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tP_uvtnC2UuLbVx8KbNwaQ)
///  <code>RC_e6a121d9e10463243528b9fbc6a71f2e</code> that represent
/// s <code>UserUserExtensionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUserExtensionRecord
public partial struct RC_e6a121d9e10463243528b9fbc6a71f2e : ITypedRecord<RC_e6a121d9e10463243528b9fbc6a71f2e> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");

public ENUserEntityRecord ssENUser;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;


public BitArray OptimizedAttributes;

public RC_e6a121d9e10463243528b9fbc6a71f2e() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUserExtension.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUserExtension.OptimizedAttributes;
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
public void ReadIM(RC_e6a121d9e10463243528b9fbc6a71f2e r) {
this = r;
}


public static bool operator == (RC_e6a121d9e10463243528b9fbc6a71f2e a, RC_e6a121d9e10463243528b9fbc6a71f2e b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
return true;
}

public static bool operator != (RC_e6a121d9e10463243528b9fbc6a71f2e a, RC_e6a121d9e10463243528b9fbc6a71f2e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e6a121d9e10463243528b9fbc6a71f2e)) return false;
return (this == (RC_e6a121d9e10463243528b9fbc6a71f2e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUserExtension.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
}


public RC_e6a121d9e10463243528b9fbc6a71f2e Duplicate() {
RC_e6a121d9e10463243528b9fbc6a71f2e t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
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
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUserExtension.Key.AsGuid) {
return ssENUserExtension;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
}
} // RC_e6a121d9e10463243528b9fbc6a71f2e
/// <summary>
/// RecordList type <code>UserUserExtensionRecordList</code> that represents a record list of
///  <code>User, UserExtension</code>
/// </summary>
public partial class RL_c5c32c91f72d14efd2c0ccca15008afa : GenericRecordList<RC_e6a121d9e10463243528b9fbc6a71f2e>, IEnumerable, IEnumerator {

protected override RC_e6a121d9e10463243528b9fbc6a71f2e GetElementDefaultValue() {
return new RC_e6a121d9e10463243528b9fbc6a71f2e();
}

public T[] ToArray<T>(Func<RC_e6a121d9e10463243528b9fbc6a71f2e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c5c32c91f72d14efd2c0ccca15008afa recordList, Func<RC_e6a121d9e10463243528b9fbc6a71f2e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c5c32c91f72d14efd2c0ccca15008afa(RC_e6a121d9e10463243528b9fbc6a71f2e[] array) {
  RL_c5c32c91f72d14efd2c0ccca15008afa result = new RL_c5c32c91f72d14efd2c0ccca15008afa();
result.InnerFromArray(array);
    return result;
}

public static RL_c5c32c91f72d14efd2c0ccca15008afa ToList<T>(T[] array, Func <T, RC_e6a121d9e10463243528b9fbc6a71f2e> converter) {
  RL_c5c32c91f72d14efd2c0ccca15008afa result = new RL_c5c32c91f72d14efd2c0ccca15008afa();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c5c32c91f72d14efd2c0ccca15008afa FromRestList<T>(RestList<T> restList, Func <T, RC_e6a121d9e10463243528b9fbc6a71f2e> converter) {
  RL_c5c32c91f72d14efd2c0ccca15008afa result = new RL_c5c32c91f72d14efd2c0ccca15008afa();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c5c32c91f72d14efd2c0ccca15008afa() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e6a121d9e10463243528b9fbc6a71f2e> NewList() {
return new RL_c5c32c91f72d14efd2c0ccca15008afa();
}


} // RL_c5c32c91f72d14efd2c0ccca15008afa
}

