namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+ko9uopifEuC9af3pSx5Vw)
///  <code>RC_79a64780c4264a7ff3588d1347b5f259</code> that represent
/// s <code>UserEntraRoleUser_Extended_InternalTelcelDirectionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserEntraRoleUser_Extended_InternalTelcelDirectionRecord
public partial struct RC_79a64780c4264a7ff3588d1347b5f259 : ITypedRecord<RC_79a64780c4264a7ff3588d1347b5f259> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GJPF90MHwEDiMLq9XqYvtQ");

public ENUserEntityRecord ssENUser;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ssENTelcelDirection;


public BitArray OptimizedAttributes;

public RC_79a64780c4264a7ff3588d1347b5f259() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENTelcelDirection = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENEntraRole.OptimizedAttributes = value[1];
    ssENUser_Extended_Internal.OptimizedAttributes = value[2];
    ssENTelcelDirection.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENEntraRole.OptimizedAttributes;
    all[2] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[3] = ssENTelcelDirection.OptimizedAttributes;
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
ssENEntraRole.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
ssENTelcelDirection.Read( r, ref index);
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
public void ReadIM(RC_79a64780c4264a7ff3588d1347b5f259 r) {
this = r;
}


public static bool operator == (RC_79a64780c4264a7ff3588d1347b5f259 a, RC_79a64780c4264a7ff3588d1347b5f259 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENTelcelDirection != b.ssENTelcelDirection) return false;
return true;
}

public static bool operator != (RC_79a64780c4264a7ff3588d1347b5f259 a, RC_79a64780c4264a7ff3588d1347b5f259 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_79a64780c4264a7ff3588d1347b5f259)) return false;
return (this == (RC_79a64780c4264a7ff3588d1347b5f259)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENTelcelDirection.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENEntraRole.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENTelcelDirection.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENTelcelDirection.InternalRecursiveSave();
}


public RC_79a64780c4264a7ff3588d1347b5f259 Duplicate() {
RC_79a64780c4264a7ff3588d1347b5f259 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENTelcelDirection = (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord)this.ssENTelcelDirection.Duplicate();
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
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssENTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("telceldirection");
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
if (key == IdEntraRole) {
return ssENEntraRole;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdTelcelDirection) {
return ssENTelcelDirection;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssENTelcelDirection;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdTelcelDirection));
}
} // RC_79a64780c4264a7ff3588d1347b5f259
/// <summary>
/// RecordList type <code>UserEntraRoleUser_Extended_InternalTelcelDirectionRecordList</code> that
///  represents a record list of <code>User, EntraRole, User_Extended_Internal, TelcelDirection</code>
/// </summary>
public partial class RL_4d304652a66e6de5c7b4ce65fcc7c50b : GenericRecordList<RC_79a64780c4264a7ff3588d1347b5f259>, IEnumerable, IEnumerator {

protected override RC_79a64780c4264a7ff3588d1347b5f259 GetElementDefaultValue() {
return new RC_79a64780c4264a7ff3588d1347b5f259();
}

public T[] ToArray<T>(Func<RC_79a64780c4264a7ff3588d1347b5f259, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4d304652a66e6de5c7b4ce65fcc7c50b recordList, Func<RC_79a64780c4264a7ff3588d1347b5f259, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4d304652a66e6de5c7b4ce65fcc7c50b(RC_79a64780c4264a7ff3588d1347b5f259[] array) {
  RL_4d304652a66e6de5c7b4ce65fcc7c50b result = new RL_4d304652a66e6de5c7b4ce65fcc7c50b();
result.InnerFromArray(array);
    return result;
}

public static RL_4d304652a66e6de5c7b4ce65fcc7c50b ToList<T>(T[] array, Func <T, RC_79a64780c4264a7ff3588d1347b5f259> converter) {
  RL_4d304652a66e6de5c7b4ce65fcc7c50b result = new RL_4d304652a66e6de5c7b4ce65fcc7c50b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4d304652a66e6de5c7b4ce65fcc7c50b FromRestList<T>(RestList<T> restList, Func <T, RC_79a64780c4264a7ff3588d1347b5f259> converter) {
  RL_4d304652a66e6de5c7b4ce65fcc7c50b result = new RL_4d304652a66e6de5c7b4ce65fcc7c50b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4d304652a66e6de5c7b4ce65fcc7c50b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_79a64780c4264a7ff3588d1347b5f259> NewList() {
return new RL_4d304652a66e6de5c7b4ce65fcc7c50b();
}


} // RL_4d304652a66e6de5c7b4ce65fcc7c50b
}

