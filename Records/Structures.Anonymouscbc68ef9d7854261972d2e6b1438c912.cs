namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+Y7Gy4XXYUKXLS5rFDjJEg)
///  <code>RC_cb3079de01243d5d6995c7751ddd690b</code> that represent
/// s <code>OrderApprovalOrderApprovalLevelEntraRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderApprovalOrderApprovalLevelEntraRoleRecord
public partial struct RC_cb3079de01243d5d6995c7751ddd690b : ITypedRecord<RC_cb3079de01243d5d6995c7751ddd690b> {
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");
internal static readonly GlobalObjectKey IdEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_1HoOmKLtNP_gEHeeBzkfQ");

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENEntraRole;


public BitArray OptimizedAttributes;

public RC_cb3079de01243d5d6995c7751ddd690b() {
OptimizedAttributes = null;
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
ssENEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(17,false);
    all[2] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderApproval.OptimizedAttributes = value[0];
    ssENOrderApprovalLevel.OptimizedAttributes = value[1];
    ssENEntraRole.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderApproval.OptimizedAttributes;
    all[1] = ssENOrderApprovalLevel.OptimizedAttributes;
    all[2] = ssENEntraRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderApproval.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
ssENEntraRole.Read( r, ref index);
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
public void ReadIM(RC_cb3079de01243d5d6995c7751ddd690b r) {
this = r;
}


public static bool operator == (RC_cb3079de01243d5d6995c7751ddd690b a, RC_cb3079de01243d5d6995c7751ddd690b b) {
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
if (a.ssENEntraRole != b.ssENEntraRole) return false;
return true;
}

public static bool operator != (RC_cb3079de01243d5d6995c7751ddd690b a, RC_cb3079de01243d5d6995c7751ddd690b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cb3079de01243d5d6995c7751ddd690b)) return false;
return (this == (RC_cb3079de01243d5d6995c7751ddd690b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
 ^ ssENEntraRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderApproval.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
ssENEntraRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderApproval.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
ssENEntraRole.InternalRecursiveSave();
}


public RC_cb3079de01243d5d6995c7751ddd690b Duplicate() {
RC_cb3079de01243d5d6995c7751ddd690b t;
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
t.ssENEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENEntraRole.Duplicate();
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
if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
} else if (head == "entrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EntraRole")) variable.Value = ssENEntraRole; else variable.Optimized = true;
variable.SetFieldName("entrarole");
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
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
if (key == IdEntraRole) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
if (attributeKey == IdEntraRole.Key.AsGuid) {
return ssENEntraRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
ssENEntraRole.FillFromOther((IRecord) other.AttributeGet(IdEntraRole));
}
} // RC_cb3079de01243d5d6995c7751ddd690b
/// <summary>
/// RecordList type <code>OrderApprovalOrderApprovalLevelEntraRoleRecordList</code> that represents a
///  record list of <code>OrderApproval, OrderApprovalLevel, EntraRole</code>
/// </summary>
public partial class RL_547a563833923ab1f4eeebb2aa95ce1a : GenericRecordList<RC_cb3079de01243d5d6995c7751ddd690b>, IEnumerable, IEnumerator {

protected override RC_cb3079de01243d5d6995c7751ddd690b GetElementDefaultValue() {
return new RC_cb3079de01243d5d6995c7751ddd690b();
}

public T[] ToArray<T>(Func<RC_cb3079de01243d5d6995c7751ddd690b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_547a563833923ab1f4eeebb2aa95ce1a recordList, Func<RC_cb3079de01243d5d6995c7751ddd690b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_547a563833923ab1f4eeebb2aa95ce1a(RC_cb3079de01243d5d6995c7751ddd690b[] array) {
  RL_547a563833923ab1f4eeebb2aa95ce1a result = new RL_547a563833923ab1f4eeebb2aa95ce1a();
result.InnerFromArray(array);
    return result;
}

public static RL_547a563833923ab1f4eeebb2aa95ce1a ToList<T>(T[] array, Func <T, RC_cb3079de01243d5d6995c7751ddd690b> converter) {
  RL_547a563833923ab1f4eeebb2aa95ce1a result = new RL_547a563833923ab1f4eeebb2aa95ce1a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_547a563833923ab1f4eeebb2aa95ce1a FromRestList<T>(RestList<T> restList, Func <T, RC_cb3079de01243d5d6995c7751ddd690b> converter) {
  RL_547a563833923ab1f4eeebb2aa95ce1a result = new RL_547a563833923ab1f4eeebb2aa95ce1a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_547a563833923ab1f4eeebb2aa95ce1a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(8,false);
def[1] = new BitArray(17,false);
def[2] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cb3079de01243d5d6995c7751ddd690b> NewList() {
return new RL_547a563833923ab1f4eeebb2aa95ce1a();
}


} // RL_547a563833923ab1f4eeebb2aa95ce1a
}

