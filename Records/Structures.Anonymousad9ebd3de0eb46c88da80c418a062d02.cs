namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Pb2erevgyEaNqAxBigYtAg)
///  <code>RC_b1aef7e4555afd67b6953fcc571f18a7</code> that represent
/// s <code>UserUserApplicationRoleUserExtensionRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUserApplicationRoleUserExtensionRegionRecord
public partial struct RC_b1aef7e4555afd67b6953fcc571f18a7 : ITypedRecord<RC_b1aef7e4555afd67b6953fcc571f18a7> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUserApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bEGhRAtqexFrflFk+dUUfw");
internal static readonly GlobalObjectKey IdUserExtension = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1RoMYh1BPbvb4GFlKcGaLg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENUser;

public EN_d70717a411b3cebe926da612400b1467EntityRecord ssENUserApplicationRole;

public EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord ssENUserExtension;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_b1aef7e4555afd67b6953fcc571f18a7() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUserApplicationRole = new EN_d70717a411b3cebe926da612400b1467EntityRecord();
ssENUserExtension = new EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(3,false);
    all[3] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUserExtension.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUserApplicationRole.OptimizedAttributes = value[1];
    ssENUserExtension.OptimizedAttributes = value[2];
    ssENRegion.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUserApplicationRole.OptimizedAttributes;
    all[2] = ssENUserExtension.OptimizedAttributes;
    all[3] = ssENRegion.OptimizedAttributes;
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
ssENUserApplicationRole.Read( r, ref index);
ssENUserExtension.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_b1aef7e4555afd67b6953fcc571f18a7 r) {
this = r;
}


public static bool operator == (RC_b1aef7e4555afd67b6953fcc571f18a7 a, RC_b1aef7e4555afd67b6953fcc571f18a7 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUserApplicationRole != b.ssENUserApplicationRole) return false;
if (a.ssENUserExtension != b.ssENUserExtension) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_b1aef7e4555afd67b6953fcc571f18a7 a, RC_b1aef7e4555afd67b6953fcc571f18a7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b1aef7e4555afd67b6953fcc571f18a7)) return false;
return (this == (RC_b1aef7e4555afd67b6953fcc571f18a7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUserApplicationRole.GetHashCode()
 ^ ssENUserExtension.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUserApplicationRole.RecursiveReset();
ssENUserExtension.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUserApplicationRole.InternalRecursiveSave();
ssENUserExtension.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_b1aef7e4555afd67b6953fcc571f18a7 Duplicate() {
RC_b1aef7e4555afd67b6953fcc571f18a7 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUserApplicationRole = (EN_d70717a411b3cebe926da612400b1467EntityRecord)this.ssENUserApplicationRole.Duplicate();
t.ssENUserExtension = (EN_f1e0c2ce033985fcca9f3086ab959521EntityRecord)this.ssENUserExtension.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "userapplicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRole")) variable.Value = ssENUserApplicationRole; else variable.Optimized = true;
variable.SetFieldName("userapplicationrole");
} else if (head == "userextension") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserExtension")) variable.Value = ssENUserExtension; else variable.Optimized = true;
variable.SetFieldName("userextension");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdUserApplicationRole) {
return ssENUserApplicationRole;
}
if (key == IdUserExtension) {
return ssENUserExtension;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUserApplicationRole.Key.AsGuid) {
return ssENUserApplicationRole;
}
if (attributeKey == IdUserExtension.Key.AsGuid) {
return ssENUserExtension;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUserApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRole));
ssENUserExtension.FillFromOther((IRecord) other.AttributeGet(IdUserExtension));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_b1aef7e4555afd67b6953fcc571f18a7
/// <summary>
/// RecordList type <code>UserUserApplicationRoleUserExtensionRegionRecordList</code> that represents a
///  record list of <code>User, UserApplicationRole, UserExtension, Region</code>
/// </summary>
public partial class RL_d3ffbc49f09f84f811cf8d55f22672cb : GenericRecordList<RC_b1aef7e4555afd67b6953fcc571f18a7>, IEnumerable, IEnumerator {

protected override RC_b1aef7e4555afd67b6953fcc571f18a7 GetElementDefaultValue() {
return new RC_b1aef7e4555afd67b6953fcc571f18a7();
}

public T[] ToArray<T>(Func<RC_b1aef7e4555afd67b6953fcc571f18a7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d3ffbc49f09f84f811cf8d55f22672cb recordList, Func<RC_b1aef7e4555afd67b6953fcc571f18a7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d3ffbc49f09f84f811cf8d55f22672cb(RC_b1aef7e4555afd67b6953fcc571f18a7[] array) {
  RL_d3ffbc49f09f84f811cf8d55f22672cb result = new RL_d3ffbc49f09f84f811cf8d55f22672cb();
result.InnerFromArray(array);
    return result;
}

public static RL_d3ffbc49f09f84f811cf8d55f22672cb ToList<T>(T[] array, Func <T, RC_b1aef7e4555afd67b6953fcc571f18a7> converter) {
  RL_d3ffbc49f09f84f811cf8d55f22672cb result = new RL_d3ffbc49f09f84f811cf8d55f22672cb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d3ffbc49f09f84f811cf8d55f22672cb FromRestList<T>(RestList<T> restList, Func <T, RC_b1aef7e4555afd67b6953fcc571f18a7> converter) {
  RL_d3ffbc49f09f84f811cf8d55f22672cb result = new RL_d3ffbc49f09f84f811cf8d55f22672cb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d3ffbc49f09f84f811cf8d55f22672cb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(3,false);
def[3] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b1aef7e4555afd67b6953fcc571f18a7> NewList() {
return new RL_d3ffbc49f09f84f811cf8d55f22672cb();
}


} // RL_d3ffbc49f09f84f811cf8d55f22672cb
}

