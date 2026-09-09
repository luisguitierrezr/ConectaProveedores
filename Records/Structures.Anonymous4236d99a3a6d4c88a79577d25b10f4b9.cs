namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mtk2Qm06iEynlXfSWxD0uQ)
///  <code>RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad</code> that represent
/// s
///  <code>OrderDistributionConfigFirstApproverEntraRoleFirstContactEntraRoleSecondApproverEntraRoleSeco
/// ndContactEntraRoleRegionNumberTelcelDirectionRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderDistributionConfigFirstApproverEntraRoleFirstContactEntraRoleSecondApproverEntraRoleSecondContactEntraRoleRegionNumberTelcelDirectionRegionRecord
public partial struct RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad : ITypedRecord<RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad> {
internal static readonly GlobalObjectKey IdOrderDistributionConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2pvFn9tBCnTof5HxNdJIEQ");
internal static readonly GlobalObjectKey IdFirstApproverEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_zzV4N58MM_ddNjjfkiP6A");
internal static readonly GlobalObjectKey IdFirstContactEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IcJI+68EL7mzOXOyQTvSjQ");
internal static readonly GlobalObjectKey IdSecondApproverEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*I1ATmZ789yaM2aSUKe01zA");
internal static readonly GlobalObjectKey IdSecondContactEntraRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bsoBXS_LiJOg8vxRqagWPA");
internal static readonly GlobalObjectKey IdRegionNumber = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*diSKDCqhW4DyBpxP1JuDeA");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GJPF90MHwEDiMLq9XqYvtQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_4ad0cdb13562998fda111463f2af9c31EntityRecord ssENOrderDistributionConfig;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENFirstApproverEntraRole;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENFirstContactEntraRole;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENSecondApproverEntraRole;

public EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord ssENSecondContactEntraRole;

public string ssRegionNumber;

public EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ssENTelcelDirection;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad() {
OptimizedAttributes = null;
ssENOrderDistributionConfig = new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord();
ssENFirstApproverEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENFirstContactEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENSecondApproverEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssENSecondContactEntraRole = new EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
ssRegionNumber = "";
ssENTelcelDirection = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(13,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(6,false);
    all[3] = new BitArray(6,false);
    all[4] = new BitArray(6,false);
    all[5] = new BitArray(7,false);
    all[6] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderDistributionConfig.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFirstApproverEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFirstContactEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENSecondApproverEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSecondContactEntraRole.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENOrderDistributionConfig.OptimizedAttributes = value[0];
    ssENFirstApproverEntraRole.OptimizedAttributes = value[1];
    ssENFirstContactEntraRole.OptimizedAttributes = value[2];
    ssENSecondApproverEntraRole.OptimizedAttributes = value[3];
    ssENSecondContactEntraRole.OptimizedAttributes = value[4];
    ssENTelcelDirection.OptimizedAttributes = value[5];
    ssENRegion.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENOrderDistributionConfig.OptimizedAttributes;
    all[1] = ssENFirstApproverEntraRole.OptimizedAttributes;
    all[2] = ssENFirstContactEntraRole.OptimizedAttributes;
    all[3] = ssENSecondApproverEntraRole.OptimizedAttributes;
    all[4] = ssENSecondContactEntraRole.OptimizedAttributes;
    all[5] = ssENTelcelDirection.OptimizedAttributes;
    all[6] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderDistributionConfig.Read( r, ref index);
ssENFirstApproverEntraRole.Read( r, ref index);
ssENFirstContactEntraRole.Read( r, ref index);
ssENSecondApproverEntraRole.Read( r, ref index);
ssENSecondContactEntraRole.Read( r, ref index);
ssRegionNumber = r.ReadText(index++, "OrderDistributionConfigFirstApproverEntraRoleFirstContactEntraRoleSecondApproverEntraRoleSecondContactEntraRoleRegionNumberTelcelDirectionRegionRecord.RegionNumber", "");
ssENTelcelDirection.Read( r, ref index);
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
public void ReadIM(RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad r) {
this = r;
}


public static bool operator == (RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad a, RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad b) {
if (a.ssENOrderDistributionConfig != b.ssENOrderDistributionConfig) return false;
if (a.ssENFirstApproverEntraRole != b.ssENFirstApproverEntraRole) return false;
if (a.ssENFirstContactEntraRole != b.ssENFirstContactEntraRole) return false;
if (a.ssENSecondApproverEntraRole != b.ssENSecondApproverEntraRole) return false;
if (a.ssENSecondContactEntraRole != b.ssENSecondContactEntraRole) return false;
if (a.ssRegionNumber != b.ssRegionNumber) return false;
if (a.ssENTelcelDirection != b.ssENTelcelDirection) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad a, RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad)) return false;
return (this == (RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderDistributionConfig.GetHashCode()
 ^ ssENFirstApproverEntraRole.GetHashCode()
 ^ ssENFirstContactEntraRole.GetHashCode()
 ^ ssENSecondApproverEntraRole.GetHashCode()
 ^ ssENSecondContactEntraRole.GetHashCode()
 ^ ssRegionNumber.GetHashCode()
 ^ ssENTelcelDirection.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderDistributionConfig.RecursiveReset();
ssENFirstApproverEntraRole.RecursiveReset();
ssENFirstContactEntraRole.RecursiveReset();
ssENSecondApproverEntraRole.RecursiveReset();
ssENSecondContactEntraRole.RecursiveReset();
ssENTelcelDirection.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderDistributionConfig.InternalRecursiveSave();
ssENFirstApproverEntraRole.InternalRecursiveSave();
ssENFirstContactEntraRole.InternalRecursiveSave();
ssENSecondApproverEntraRole.InternalRecursiveSave();
ssENSecondContactEntraRole.InternalRecursiveSave();
ssENTelcelDirection.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad Duplicate() {
RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad t;
t.ssENOrderDistributionConfig = (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord)this.ssENOrderDistributionConfig.Duplicate();
t.ssENFirstApproverEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENFirstApproverEntraRole.Duplicate();
t.ssENFirstContactEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENFirstContactEntraRole.Duplicate();
t.ssENSecondApproverEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENSecondApproverEntraRole.Duplicate();
t.ssENSecondContactEntraRole = (EN_d27d6d10f66f82966903ca7fd33164f8EntityRecord)this.ssENSecondContactEntraRole.Duplicate();
t.ssRegionNumber = this.ssRegionNumber;
t.ssENTelcelDirection = (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord)this.ssENTelcelDirection.Duplicate();
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
if (head == "orderdistributionconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDistributionConfig")) variable.Value = ssENOrderDistributionConfig; else variable.Optimized = true;
variable.SetFieldName("orderdistributionconfig");
} else if (head == "firstapproverentrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstApproverEntraRole")) variable.Value = ssENFirstApproverEntraRole; else variable.Optimized = true;
variable.SetFieldName("firstapproverentrarole");
} else if (head == "firstcontactentrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FirstContactEntraRole")) variable.Value = ssENFirstContactEntraRole; else variable.Optimized = true;
variable.SetFieldName("firstcontactentrarole");
} else if (head == "secondapproverentrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SecondApproverEntraRole")) variable.Value = ssENSecondApproverEntraRole; else variable.Optimized = true;
variable.SetFieldName("secondapproverentrarole");
} else if (head == "secondcontactentrarole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SecondContactEntraRole")) variable.Value = ssENSecondContactEntraRole; else variable.Optimized = true;
variable.SetFieldName("secondcontactentrarole");
} else if (head == "regionnumber") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionNumber")) variable.Value = ssRegionNumber; else variable.Optimized = true;
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssENTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("telceldirection");
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
if (key == IdOrderDistributionConfig) {
return ssENOrderDistributionConfig;
}
if (key == IdFirstApproverEntraRole) {
return ssENFirstApproverEntraRole;
}
if (key == IdFirstContactEntraRole) {
return ssENFirstContactEntraRole;
}
if (key == IdSecondApproverEntraRole) {
return ssENSecondApproverEntraRole;
}
if (key == IdSecondContactEntraRole) {
return ssENSecondContactEntraRole;
}
if (key == IdRegionNumber) {
return ssRegionNumber;
}
if (key == IdTelcelDirection) {
return ssENTelcelDirection;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderDistributionConfig.Key.AsGuid) {
return ssENOrderDistributionConfig;
}
if (attributeKey == IdFirstApproverEntraRole.Key.AsGuid) {
return ssENFirstApproverEntraRole;
}
if (attributeKey == IdFirstContactEntraRole.Key.AsGuid) {
return ssENFirstContactEntraRole;
}
if (attributeKey == IdSecondApproverEntraRole.Key.AsGuid) {
return ssENSecondApproverEntraRole;
}
if (attributeKey == IdSecondContactEntraRole.Key.AsGuid) {
return ssENSecondContactEntraRole;
}
if (attributeKey == IdRegionNumber.Key.AsGuid) {
return ssRegionNumber;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssENTelcelDirection;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderDistributionConfig.FillFromOther((IRecord) other.AttributeGet(IdOrderDistributionConfig));
ssENFirstApproverEntraRole.FillFromOther((IRecord) other.AttributeGet(IdFirstApproverEntraRole));
ssENFirstContactEntraRole.FillFromOther((IRecord) other.AttributeGet(IdFirstContactEntraRole));
ssENSecondApproverEntraRole.FillFromOther((IRecord) other.AttributeGet(IdSecondApproverEntraRole));
ssENSecondContactEntraRole.FillFromOther((IRecord) other.AttributeGet(IdSecondContactEntraRole));
ssRegionNumber = (string) other.AttributeGet(IdRegionNumber);
ssENTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdTelcelDirection));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad
/// <summary>
/// RecordList type
///  <code>OrderDistributionConfigFirstApproverEntraRoleFirstContactEntraRoleSecondApproverEntraRoleSeco
/// ndContactEntraRoleRegionNumberTelcelDirectionRegionRecordList</code> that represents a record list
///  of <code>OrderDistributionConfig, EntraRole, EntraRole, EntraRole, EntraRole, Text
/// , TelcelDirection, Region</code>
/// </summary>
public partial class RL_fad66e2f0a5803b0832cea3f3e9146e2 : GenericRecordList<RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad>, IEnumerable, IEnumerator {

protected override RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad GetElementDefaultValue() {
return new RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad();
}

public T[] ToArray<T>(Func<RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fad66e2f0a5803b0832cea3f3e9146e2 recordList, Func<RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fad66e2f0a5803b0832cea3f3e9146e2(RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad[] array) {
  RL_fad66e2f0a5803b0832cea3f3e9146e2 result = new RL_fad66e2f0a5803b0832cea3f3e9146e2();
result.InnerFromArray(array);
    return result;
}

public static RL_fad66e2f0a5803b0832cea3f3e9146e2 ToList<T>(T[] array, Func <T, RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad> converter) {
  RL_fad66e2f0a5803b0832cea3f3e9146e2 result = new RL_fad66e2f0a5803b0832cea3f3e9146e2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fad66e2f0a5803b0832cea3f3e9146e2 FromRestList<T>(RestList<T> restList, Func <T, RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad> converter) {
  RL_fad66e2f0a5803b0832cea3f3e9146e2 result = new RL_fad66e2f0a5803b0832cea3f3e9146e2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fad66e2f0a5803b0832cea3f3e9146e2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(13,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(6,false);
def[3] = new BitArray(6,false);
def[4] = new BitArray(6,false);
def[5] = new BitArray(7,false);
def[6] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad> NewList() {
return new RL_fad66e2f0a5803b0832cea3f3e9146e2();
}


} // RL_fad66e2f0a5803b0832cea3f3e9146e2
}

